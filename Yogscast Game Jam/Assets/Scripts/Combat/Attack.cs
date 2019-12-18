using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    [SerializeField]
    const int m_iHeavyBonusDam = 5, m_iHeavyDebuff = -3; /*! < \var These are the bonuses/debuffs for the heavy attack option. */

    [SerializeField]
    const int m_iLightLessDam = -3, m_iLighthitChance = 3; /*! < \var These are the bonuses/debuffs for the light attack option. */

    int m_bMadeDecision = -1; /*! < \var This will be used to check which attack the player has used. */ 

    public int m_iCurrentAttackValue; /*! < \var The current attack value. used to inflict damage to the opponent. */ 

    public int m_iCurrentDiceValue; /*! < \var The current dice value. used to check the dice value. */

    /*! \fn This will be used to calculate the damage for the attack. */
    public int m_Attack(int attackType, int attackValue, int hitChance, int hitDice)
    {

        int l_iDamage = 0;

        m_iCurrentDiceValue = hitDice; 

        if (attackType == 1) // < Heavy Attack 
        {
            if(hitDice - m_iHeavyDebuff >= hitChance)
            {
                l_iDamage = attackValue + m_iHeavyBonusDam;

                m_iCurrentAttackValue = l_iDamage;
            }
        }
        else // < Light attack 
        {
            if (hitDice + m_iLighthitChance >= hitChance)
            {
                l_iDamage = attackValue - m_iLightLessDam;

                m_iCurrentAttackValue = l_iDamage;
            }
        }

        return l_iDamage; 
    }

    /*! \fn This will be used to select a light attack. */ 
    public void m_MakeLight()
    {
        m_bMadeDecision = 0;
    }

    /*! \fn This will be used to select a heavy attack. */
    public void m_MakeHeavy()
    {
        m_bMadeDecision = 1;
    }

    /*! \fn This will be used to check what decision the player has made. */
    public int m_MadeDecision()
    {
        return m_bMadeDecision;
    }

    /*! \fn This will be used to reset the variables at the end of the attack. */
    public void m_ResetBools()
    {
        m_bMadeDecision = -1;
    }

}
