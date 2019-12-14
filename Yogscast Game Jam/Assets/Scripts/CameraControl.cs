using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    [SerializeField]
    GameObject m_CameraTarget; 

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position != m_CameraTarget.transform.position)
        {
            Vector3 l_NewPos;

            l_NewPos.x = m_CameraTarget.transform.position.x;
            l_NewPos.y = m_CameraTarget.transform.position.y;
            l_NewPos.z = transform.position.z; 

            transform.position = l_NewPos;
        }
    }
}
