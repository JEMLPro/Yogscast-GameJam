using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class InterfaceManager : MonoBehaviour
{
    [SerializeField]
    GameObject m_PlayerObject = null;

    [SerializeField]
    Text m_HealthText = null;

    [SerializeField]
    Text m_RoomCountText = null; 

    // Start is called before the first frame update
    void Start()
    {
        m_PlayerObject = GameObject.FindGameObjectWithTag("Player");
    }

    void Update()
    {
        string l_sNewHealthText = "Health " + m_PlayerObject.GetComponent<Stats>().m_GetHealth().ToString(); 

        m_HealthText.text = l_sNewHealthText;

        string l_sNewRoomText = "Room " + SceneManager.GetActiveScene().buildIndex;

        m_RoomCountText.text = l_sNewRoomText;
    }
}
