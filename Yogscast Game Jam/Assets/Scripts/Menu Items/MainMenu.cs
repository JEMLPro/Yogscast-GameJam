using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MainMenu : MonoBehaviour
{
    /*! \fn Used to move to the next scene. */
    public void m_StartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); 
    }

    /*! \fn This will exit the application. */
    public void m_ExitGame() 
    {
        Debug.Log("Game Exited");

        Application.Quit();
    }
}
