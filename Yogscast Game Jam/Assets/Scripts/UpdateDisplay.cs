using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdateDisplay : MonoBehaviour
{
    [SerializeField]
    TMPro.TMP_Text m_ChoiceText;

    [SerializeField]
    TMPro.TMP_Text m_DiceRollText;

    [SerializeField]
    GameObject m_PlayerObject;

    [SerializeField]
    GameObject m_EnemyObject; 

    private void Update()
    {
        int l_iDefendDecision = m_PlayerObject.GetComponent<Defend>().m_MadeDecision();

        if (l_iDefendDecision != -1)
        {
            int l_iDiceValue = m_PlayerObject.GetComponent<Defend>().m_iCurrentDiceValue;
            int l_iAttackValue = m_EnemyObject.GetComponent<Attack>().m_iCurrentAttackValue;

            m_DiceRollText.text = l_iDiceValue.ToString();

            if (l_iAttackValue > 0)
            {
                if (l_iDefendDecision == 1)
                {
                    m_ChoiceText.text = "Blocked";
                }
                else
                {
                    m_ChoiceText.text = "Full Damage";
                }
            }
            else
            {
                m_ChoiceText.text = "Evaded";
            }
        }

        int l_iAttackDecision = m_PlayerObject.GetComponent<Attack>().m_MadeDecision();

        if (l_iAttackDecision != -1)
        {
            int l_iDiceValue = m_PlayerObject.GetComponent<Attack>().m_iCurrentDiceValue;
            int l_iAttackValue = m_EnemyObject.GetComponent<Defend>().m_iCurrentDamageValue;

            m_DiceRollText.text = l_iDiceValue.ToString(); 

            if (l_iAttackValue > 0)
            {
                m_ChoiceText.text = "Hit";
            }
            else
            {
                m_ChoiceText.text = "Missed";
            }
        }

    }
}
