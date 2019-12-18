using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GenerateEnemy : MonoBehaviour
{
    [SerializeField]
    GameObject m_GameManager; /*! \var This will be the current game manager, this will tell the game what mode it's in.*/

    [SerializeField]
    GameObject m_EnemySprite; /*! \var This will be the current enemy sprite. */ 

    [SerializeField]
    GameObject m_EnemyStats; /*! \var This will hold the current enemies stats. */ 

    bool m_SpawnOne = false; 

    // Update is called once per frame
    void Update()
    {
       if(m_GameManager.GetComponent<GenerateRandomEnounter>().CheckEncounterValue() == true)
        {
            if (m_SpawnOne == false)
            {
                m_SpawnOne = true; // Allows for a single spawn. 

                GameObject l_CurrentEnemy = gameObject.GetComponent<EnemyManager>().m_GetEnemyObject();

                m_EnemySprite.GetComponent<Image>().sprite = l_CurrentEnemy.GetComponent<SpriteRenderer>().sprite;

                m_EnemyStats.GetComponent<Stats>().m_SetName(l_CurrentEnemy.GetComponent<Stats>().m_GetName());

                m_EnemyStats.GetComponent<Stats>().m_SetHealth(l_CurrentEnemy.GetComponent<Stats>().m_GetHealth());
            }
        }
    }
    public void m_ResetEnemy()
    {
        m_SpawnOne = false; 
    }

    public bool m_CheckSpawn()
    {
        return m_SpawnOne; 
    }

}
