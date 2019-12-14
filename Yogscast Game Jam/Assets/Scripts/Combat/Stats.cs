using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stats : MonoBehaviour
{
    [SerializeField]
    int m_iHealth = 100; /*! < \var The Health of the entity, if it reaches 0 they die. */ 

    [SerializeField]
    int m_iAttack = 5; /*! < \var The attack stat for the entity the damage they will deal if they hit the opponent. */

    [SerializeField]
    int m_iHit = 10;

    [SerializeField]
    int m_iDefence = 5; /*! \var The defence stat for the entity. the chance the have to take reduced damage from the attack. */ 

    [SerializeField] 
    int m_iEvade = 5; /*! \var The evade stat for the entity, their chance to avoid all incoming damage. */

    [SerializeField]
    string m_CurrName = "Placeholder"; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void m_SetHealth(int newHealth)
    {
        m_iHealth = newHealth; 
    }

    public int m_GetHealth()
    {
        return m_iHealth;
    }

    public int m_GetAttack()
    {
        return m_iAttack;
    }

    public int m_GetHit()
    {
        return m_iHit;
    }

    public int m_GetDefence()
    {
        return m_iDefence; 
    }

    public int m_GetEvade()
    {
        return m_iEvade;
    }

    public void m_SetName(string newName)
    {
        m_CurrName = newName; 
    }

    public string m_GetName()
    {
        return m_CurrName; 
    }
}
