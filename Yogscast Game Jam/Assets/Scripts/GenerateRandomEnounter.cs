using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateRandomEnounter : MonoBehaviour
{
    [SerializeField]
    const int m_iRandomChance = 5; /*! < \var The chance for a randomencounter to occur, it is betewwn 0 and this int value. */

    [SerializeField]
    float m_fCurrentTimer = 0.0f; /*! < \var The current timer, to limit the amount of random numbers generated each frame.  */

    [SerializeField]
    bool m_bStartFight = false;  /*! < \var This will tell other portins of the game thatit should begi the combat loop.  */

    GameObject m_PlayerObject; 

    // Start is called before the first frame update
    void Start()
    {
        m_PlayerObject = GameObject.FindGameObjectWithTag("Player"); 
    }

    // Update is called once per frame
    void Update()
    {
        // Uses the time since last frame to create a timer. 
        m_fCurrentTimer += Time.deltaTime;

        // After the timer has reached past a certain range geerate a random number.
        if (m_fCurrentTimer >= 0.5f)
        {
            // Reset the timer to prevent multiple calls after the initial time limit. 
            m_fCurrentTimer = 0;

            if (m_PlayerObject.GetComponent<Movement>() != null)
            {
                if (m_PlayerObject.GetComponent<Movement>().m_GetIsMoving() == true)
                {
                    int l_iCurrRand = Random.Range(0, 100);

                    if (l_iCurrRand <= m_iRandomChance)
                    {
                        Debug.Log("Enemy Encounter");

                        // This boolean lets the program know that the encounter should happen. 

                        m_bStartFight = true;
                    }
                }
            }
        }
    }

    bool CheckEncounterValue()
    {
        return m_bStartFight; 
    }
}
