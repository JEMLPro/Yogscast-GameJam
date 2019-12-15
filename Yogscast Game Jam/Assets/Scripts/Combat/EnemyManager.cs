using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    [SerializeField]
    List<GameObject> v_ListOfEnemies; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void m_AddEnemy(GameObject newEnemy)
    {
        v_ListOfEnemies.Add(newEnemy);
    }

    public GameObject m_GetEnemyObject()
    {
        int l_iRand = Random.Range(0, v_ListOfEnemies.Count);

        // Debug.Log("Enemy Number " + l_iRand);

        return v_ListOfEnemies[l_iRand]; 
    }
}
