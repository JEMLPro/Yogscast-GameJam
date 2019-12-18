using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackButton : MonoBehaviour
{
    /*! \fn Used to load the main menu scene. */
    public void m_ExitGame() 
    {
        SceneManager.LoadScene(0);
    }
}
