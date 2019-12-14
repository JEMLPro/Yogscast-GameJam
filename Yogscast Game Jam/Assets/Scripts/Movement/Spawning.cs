using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawning : MonoBehaviour
{
    [SerializeField]
    Vector3 m_StartPos;

    [SerializeField]
    GameObject m_SpawnPoint;

    // Start is called before the first frame update
    void Start()
    {
        m_SpawnPoint = GameObject.FindGameObjectWithTag("Respawn");

        m_StartPos = m_SpawnPoint.transform.position; 

        transform.position = m_StartPos; 
    }
}
