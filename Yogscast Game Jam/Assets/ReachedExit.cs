using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReachedExit : MonoBehaviour
{
    [SerializeField]
    bool m_bReachedEnd = false;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            Debug.Log("Next Level");

            m_bReachedEnd = true;
        }
    }
}
