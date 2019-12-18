using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManageBattle : MonoBehaviour
{
    [SerializeField]
    GameObject m_PlayerObject; /*! < \var The current player object in the game. */

    [SerializeField]
    GameObject m_EnemyObject; /*! < \var The Current nemy object in the combat phase. */ 

    // Update is called once per frame
    void Update()
    {
        m_DefendResolution(); // Used to reolve the block of this round. 

        m_AttackResolution(); // Used to resolve the attack of this round. 
    }


    void m_DefendResolution()
    {
        int l_iDefendDecision = m_PlayerObject.GetComponent<Defend>().m_MadeDecision();

        if (l_iDefendDecision != -1)
        {
            // Debug.Log("Player Defend");

            // Debug.Log("Choice Made");

            //------------------------------------------------------------
            // Enemy Action is selected. 
            int l_iAttackType = gameObject.GetComponent<RandGenerator>().m_RandomInt(0, 1);
            int l_iAttackDam = m_EnemyObject.GetComponent<Stats>().m_GetAttack();
            int l_iHitChance = m_EnemyObject.GetComponent<Stats>().m_GetHit();
            int l_iHitDice = gameObject.GetComponent<RandGenerator>().m_RandomInt(1, 20);

            // Debug.Log("Hit Chance = " + l_iHitDice);

            //------------------------------------------------------------
            // Attack/Damage is generated. 

            int l_attackRes = 0;

            l_attackRes = m_EnemyObject.GetComponent<Attack>().m_Attack(l_iAttackType, l_iAttackDam, l_iHitChance, l_iHitDice);

            // Debug.Log("Damage " + l_attackRes);

            //------------------------------------------------------------
            // Player defence action is selected 

            int l_iBlockOrEvadeValue = 0;

            if (l_iDefendDecision == 0)
            {
                l_iBlockOrEvadeValue = m_PlayerObject.GetComponent<Stats>().m_GetEvade();
            }
            else
            {
                l_iBlockOrEvadeValue = m_PlayerObject.GetComponent<Stats>().m_GetDefence();
            }

            l_iHitDice = gameObject.GetComponent<RandGenerator>().m_RandomInt(1, 20);

            //------------------------------------------------------------
            // Total Damage is calculated. 

            int l_TotalDamage = 0;

            l_TotalDamage = m_PlayerObject.GetComponent<Defend>().m_Defend(l_iDefendDecision, l_attackRes, l_iBlockOrEvadeValue, l_iHitDice);

            int l_iPrevHealth = m_PlayerObject.GetComponent<Stats>().m_GetHealth();

            // Debug.Log("Total Damage = " + l_TotalDamage);

            //------------------------------------------------------------
            // Update of health display. 

            int l_iNewHealth = l_iPrevHealth - l_TotalDamage;

            m_PlayerObject.GetComponent<Stats>().m_SetHealth(l_iNewHealth);

            // Debug.Log("Health " + l_iNewHealth);

            //------------------------------------------------------------
            // Reset variables. 

            m_PlayerObject.GetComponent<Defend>().m_ResetBools();
        }
    }

    void m_AttackResolution()
    {
        int l_iAttackDecision = m_PlayerObject.GetComponent<Attack>().m_MadeDecision();

        if (l_iAttackDecision != -1)
        {
            // Debug.Log("Player Attack");

            // Debug.Log("Choice Made");

            //------------------------------------------------------------
            // Player Attack is generated

            int l_iAttackType = l_iAttackDecision;
            int l_iAttackDam = m_PlayerObject.GetComponent<Stats>().m_GetAttack();
            int l_iHitChance = m_PlayerObject.GetComponent<Stats>().m_GetHit();
            int l_iHitDice = gameObject.GetComponent<RandGenerator>().m_RandomInt(1, 20);

            // Debug.Log("Hit Chance = " + l_iHitDice);

            //------------------------------------------------------------
            // Attack/Damage is calculated. 

            int l_attackRes = 0;

            l_attackRes = m_PlayerObject.GetComponent<Attack>().m_Attack(l_iAttackType, l_iAttackDam, l_iHitChance, l_iHitDice);

            // Debug.Log("Damage " + l_attackRes);

            //------------------------------------------------------------
            // Enemy Defence is selected. 

            int l_iBlockOrEvadeValue = 0;

            int l_iEnemyAct = gameObject.GetComponent<RandGenerator>().m_RandomInt(0, 1);

            if (l_iEnemyAct == 0)
            {
                l_iBlockOrEvadeValue = m_EnemyObject.GetComponent<Stats>().m_GetEvade();
            }
            else
            {
                l_iBlockOrEvadeValue = m_EnemyObject.GetComponent<Stats>().m_GetDefence();
            }

            l_iHitDice = gameObject.GetComponent<RandGenerator>().m_RandomInt(1, 20);

            //------------------------------------------------------------
            // Total Damage dealt is calculated. 

            int l_TotalDamage = 0;

            l_TotalDamage = m_EnemyObject.GetComponent<Defend>().m_Defend(l_iEnemyAct, l_attackRes, l_iBlockOrEvadeValue, l_iHitDice);

            //------------------------------------------------------------
            // Enamy health is updated. 

            int l_iPrevHealth = m_EnemyObject.GetComponent<Stats>().m_GetHealth();

            // Debug.Log("Total Damage = " + l_TotalDamage);

            int l_iNewHealth = l_iPrevHealth - l_TotalDamage;

            m_EnemyObject.GetComponent<Stats>().m_SetHealth(l_iNewHealth);

            // Debug.Log("Health " + l_iNewHealth);

            //------------------------------------------------------------
            // Reset variables. 

            m_PlayerObject.GetComponent<Attack>().m_ResetBools();
        }
    }
}
