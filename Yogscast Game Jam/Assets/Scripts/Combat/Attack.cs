using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    [SerializeField]
    const int m_iHeavyBonusDam = 5, m_iHeavyDebuff = -3; /*! < \var These are the bonuses/debuffs for the heavy attack option. */

    [SerializeField]
    const int m_iLightLessDam = -3, m_iLighthitChance = 3; /*! < \var These are the bonuses/debuffs for the light attack option. */

    int m_bMadeDecision = -1;

    public int m_Attack(int attackType, int attackValue, int hitChance, int hitDice)
    {
        int l_iDamage = 0;

        if(attackType == 1) // < Heavy Attack 
        {
            if(hitDice - m_iHeavyDebuff >= hitChance)
            {
                l_iDamage = attackValue + m_iHeavyBonusDam;
            }
        }
        else // < Light attack 
        {
            if (hitDice + m_iLighthitChance >= hitChance)
            {
                l_iDamage = attackValue - m_iLightLessDam;
            }
        }

        return l_iDamage; 
    }

    public void m_MakeLight()
    {
        m_bMadeDecision = 0;
    }

    public void m_MakeHeavy()
    {
        m_bMadeDecision = 1;
    }

    public int m_MadeDecision()
    {
        return m_bMadeDecision;
    }

    public void m_ResetBools()
    {
        m_bMadeDecision = -1;
    }

}
