using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndCombat : MonoBehaviour
{
    [SerializeField]
    GameObject m_PlayerObject; /*! < \var The player object, allowing to check it's current condition. */

    [SerializeField]
    GameObject m_EnemyObject; /*! < \var The Enemy object, alowing for checking of it's current condidtion. */

    [SerializeField]
    GameObject m_ResetEnemy; 

    [SerializeField]
    GameObject m_MainCombatLoop; /*! < \var The game loop within the combat menu, alloing for activating/deactivating. */

    [SerializeField]
    GameObject m_MainGameLoop; /*! < \var The main game loop where the player interacts with the level, alloing for activating/deactivating. */

    [SerializeField]
    GameObject m_GameOverScreen; /*! < \var The screen if the player loses the game. */

    [SerializeField]
    GameObject m_PassOverStats; /*! < \var The game manager allowing for the updating of status between game loops. */

    private void Update()
    {
        if (m_ResetEnemy.GetComponent<GenerateEnemy>().m_CheckSpawn() == true)
        {
            if (m_EnemyObject.GetComponent<Stats>().m_GetHealth() <= 0) // Check if enemy killed.
            {
                // Debug.Log("Enemy Killed");

                m_MainGameLoop.SetActive(true);

                // Switch active modes. 

                m_MainCombatLoop.SetActive(false);

                // Pass over the stats to the other game mode. 

                m_PassOverStats.GetComponent<Stats>().m_SetHealth(m_PlayerObject.GetComponent<Stats>().m_GetHealth());

                m_PassOverStats.GetComponent<GenerateRandomEnounter>().m_EndFight();

                // Reset Enemy 

                m_ResetEnemy.GetComponent<GenerateEnemy>().m_ResetEnemy();

                // Exit fight. 
            }

            if (m_PlayerObject.GetComponent<Stats>().m_GetHealth() <= 0) // Check if player Killed. 
            {
                // Debug.Log("Player Killed");

                m_GameOverScreen.SetActive(true);

                // Set screen to game over. 

                m_MainCombatLoop.SetActive(false);

                // Exit fight. 
            }
        }
    }
}
