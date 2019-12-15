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

}
