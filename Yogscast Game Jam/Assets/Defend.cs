using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Defend : MonoBehaviour
{
    [SerializeField]
    bool m_bDodge = false;

    [SerializeField]
    bool m_bBlock = false;

    [SerializeField]
    int m_bMadeDecision = -1;

    public int m_Defend(int defendType, int attackValue, int blockOrEvade, int hitDice)
    {
        int l_iDamage = attackValue;

        if (defendType == 1) // < Block
        {
            if (hitDice >= attackValue - blockOrEvade)
            {
                l_iDamage /= 3;
            }
        }
        else // < Evade
        {
            if (hitDice <= blockOrEvade)
            {
                l_iDamage = 0;
            }
        }

        return l_iDamage;
    }


    public void m_MakeDodge()
    {
        m_bDodge = true;

        m_bBlock = false;

        m_bMadeDecision = 0;
    }

    public void m_MakeBlock()
    {
        m_bDodge = false;

        m_bBlock = true;

        m_bMadeDecision = 1;
    }

    public int m_MadeDecision()
    {
        return m_bMadeDecision;
    }

    public void m_ResetBools()
    {
        m_bBlock = false;

        m_bDodge = false;

        m_bMadeDecision = -1;
    }
}