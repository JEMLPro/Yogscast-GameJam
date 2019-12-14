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
    int m_iDefence = 5; /*! \var The defence stat for the entity. the chance the have to take reduced damage from the attack. */ 

    [SerializeField] 
    int m_iEvade = 5; /*! \var The evade stat for the entity, their chance to avoid all incoming damage. */ 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    int m_GetHealth()
    {
        return m_iHealth;
    }

    int m_GetAttack()
    {
        return m_iAttack;
    }

    int m_GetDefence()
    {
        return m_iDefence; 
    }

    int m_GetEvade()
    {
        return m_iEvade;
    }
}
