using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlaySounds : MonoBehaviour
{
    [SerializeField]
    AudioSource m_GruntSound;

    [SerializeField]
    AudioSource m_BumpSound;

    [SerializeField]
    AudioSource m_SBashSound;

    [SerializeField]
    AudioSource m_BackgroundMusic;

    [SerializeField]
    AudioSource m_BackgroundSound;

    [SerializeField]
    GameObject m_GameState;

    private void Update()
    {
        if(m_GameState.GetComponent<GenerateRandomEnounter>().CheckEncounterValue() == true)
        {
            if (!m_BackgroundMusic.isPlaying)
            {
                m_PlayBackgroundM();
                m_BackgroundSound.Stop();
            }
        }
        else
        {
            if (!m_BackgroundSound.isPlaying)
            {
                m_PlayBackgroundS();
                m_BackgroundMusic.Stop();
            }
        }
    }

    public void m_PlayGrunt()
    {
        m_GruntSound.Play(); 
    }

    public void m_PlayBump()
    {
        m_BumpSound.Play();
    }

    public void m_PlaySBash()
    {
        m_SBashSound.Play();
    }

    public void m_PlayBackgroundS()
    {
        m_BackgroundSound.Play();
    }

    public void m_PlayBackgroundM()
    {
        m_BackgroundMusic.Play();
    }

}
