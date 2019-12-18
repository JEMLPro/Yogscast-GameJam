using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    [SerializeField]
    List<GameObject> v_ListOfEnemies; /*! \var This will hold a list of enemies within the game. */

    /*! \fn This will allow for the adding of enemies into the list during gameplay. */ 
    void m_AddEnemy(GameObject newEnemy)
    {
        v_ListOfEnemies.Add(newEnemy);
    }

    /*! \fn THis will return a random enemy object from the list. */
    public GameObject m_GetEnemyObject()
    {
        int l_iRand = Random.Range(0, v_ListOfEnemies.Count);

        // Debug.Log("Enemy Number " + l_iRand);

        return v_ListOfEnemies[l_iRand]; 
    }
}
