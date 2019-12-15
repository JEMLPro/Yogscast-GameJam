using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReachedExit : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            // Debug.Log("Next Level");

            int l_iRandom = 0;

            l_iRandom = Random.Range(1, SceneManager.sceneCountInBuildSettings);

            // Debug.Log("Number Of Scenes" + SceneManager.sceneCount + ", Loaded : " + l_iRandom); 

            SceneManager.LoadScene(l_iRandom); 
        }
    }
}
