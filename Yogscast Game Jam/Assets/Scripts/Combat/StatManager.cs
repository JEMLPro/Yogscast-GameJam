using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StatManager : MonoBehaviour
{
    [SerializeField]
    GameObject m_PlayerObject; /*! < \var The Current player object, Has all of their stats. */

    [SerializeField]
    TMPro.TMP_Text m_HealthText; /*! < \var The Health Text on the screen. */

    [SerializeField]
    TMPro.TMP_Text m_AttackText; /*! < \var The Attack text on the screen. */

    [SerializeField]
    TMPro.TMP_Text m_DodgeText; /*! < \var The Dodge text on the screen. */

    [SerializeField]
    TMPro.TMP_Text m_BlockText; /*! < \var The Block text on the screen. */

    [SerializeField]
    TMPro.TMP_Text m_NameText; /*! < \var The Name text on the screen. */

    // Start is called before the first frame update
    void Start()
    {
        if (m_AttackText != null)
        {
            m_AttackText.SetText("Attack " + m_PlayerObject.GetComponent<Stats>().m_GetAttack().ToString());

            m_DodgeText.SetText("Dodge " + m_PlayerObject.GetComponent<Stats>().m_GetEvade().ToString());

            m_BlockText.SetText("Block " + m_PlayerObject.GetComponent<Stats>().m_GetDefence().ToString());
        }
        else
        {
            m_NameText.SetText(m_PlayerObject.GetComponent<Stats>().m_GetName());
        }
    }

    // Update is called once per frame
    void Update()
    {
        m_HealthText.SetText("Health " + m_PlayerObject.GetComponent<Stats>().m_GetHealth().ToString());

        if (m_NameText != null) 
        {
            m_NameText.SetText(m_PlayerObject.GetComponent<Stats>().m_GetName());
        }
    }
}
