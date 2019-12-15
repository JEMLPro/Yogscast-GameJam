using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StatManager : MonoBehaviour
{
    [SerializeField]
    GameObject m_PlayerObject;

    [SerializeField]
    TMPro.TMP_Text m_HealthText;

    [SerializeField]
    TMPro.TMP_Text m_AttackText;

    [SerializeField]
    TMPro.TMP_Text m_DodgeText;

    [SerializeField]
    TMPro.TMP_Text m_BlockText;

    [SerializeField]
    TMPro.TMP_Text m_NameText; 
 
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
