using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Defend : MonoBehaviour
{
    [SerializeField]
    int m_bMadeDecision = -1; /*! < \var This will be used to determine which action has been taken. */

    public int m_iCurrentDamageValue;

    public int m_iCurrentDiceValue;

    public int m_Defend(int defendType, int attackValue, int blockOrEvade, int hitDice)
    {
        int l_iDamage = attackValue; // The amount of incoming damage the opponent has dealt.

        m_iCurrentDiceValue = hitDice; 

        if (defendType == 1) // < Block
        {
            if (hitDice >= attackValue - blockOrEvade) // if the user blocks;
            {
                // They roll a dice and if the dice is higher then the attack - their block stat they take 1/3 of the damage. 

                l_iDamage /= 3;
            }
        }
        else // < Evade
        {
            if (hitDice <= blockOrEvade) // If the user dodges/evades (chaning the naming through the project == bad )
            {
                // if the player rolls less than their evade stat (Usually a low number/less likely), then they take 0 damage

                l_iDamage = 0;
            }
        }

        m_iCurrentDamageValue = l_iDamage;

        // The adjusted damage value. 
        return l_iDamage;
    }


    public void m_MakeDodge()
    {
        m_bMadeDecision = 0; // If his is == 0 it is a dodge.
    }

    public void m_MakeBlock()
    {
        m_bMadeDecision = 1; // If his is == 1 it is a dodge.
    }

    public int m_MadeDecision()
    {
        return m_bMadeDecision; // Allows for external cheching of the decision made. 
    }

    public void m_ResetBools()
    {
        m_bMadeDecision = -1; // If this is anything other than 0 or 1, it has no affect on things. 
    }
}