using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    [SerializeField]
    GameObject m_CameraTarget = null; /*! < \var The target game object which the camera will follow. */ 

    // Start is called before the first frame update
    void Start()
    {
        // This looks for the first game object with the tag player, linking the camera to the player. 
        m_CameraTarget = GameObject.FindGameObjectWithTag("Player"); 
    }

    // Update is called once per frame
    void Update()
    {
        // If the player hasn't moved, don't move the camera. 
        if(transform.position != m_CameraTarget.transform.position)
        {
            Vector3 l_NewPos;

            // Create a new vector3 using a mixture of the player's (X, Y) and the camera's current (Z). 

            l_NewPos.x = m_CameraTarget.transform.position.x;
            l_NewPos.y = m_CameraTarget.transform.position.y;
            l_NewPos.z = transform.position.z; 

            // Set the new camera position.

            transform.position = l_NewPos;
        }
    }
}
