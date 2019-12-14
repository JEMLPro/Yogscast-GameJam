using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField]
    float m_fSpeed = 5f; /*! < \var The current speed value for the player. */

    bool m_bIsMoving = false; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Uses the directional input built in with the game engine to move the player. 
        // The delta tile will be used to reduce the overall speed to allow for varied frame rates to play at similar speeds. 
        float l_fYTranslation = (Input.GetAxis("Vertical") * m_fSpeed) * Time.deltaTime;

        float l_fXTranslation = (Input.GetAxis("Horizontal") * m_fSpeed) * Time.deltaTime;

        if((Input.GetAxis("Vertical") > 0 || Input.GetAxis("Vertical") < 0) || ((Input.GetAxis("Horizontal") > 0 || Input.GetAxis("Horizontal") < 0)))
        {
            // Debug.Log("Moving");

            m_bIsMoving = true;
        }
        else
        {
            m_bIsMoving = false;
        }

        // Translates the player on the map. 
        transform.Translate(l_fXTranslation, l_fYTranslation, 0);
    }

    public bool m_GetIsMoving()
    {
        return m_bIsMoving; 
    }

}
