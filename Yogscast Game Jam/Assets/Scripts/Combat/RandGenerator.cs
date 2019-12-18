using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandGenerator : MonoBehaviour
{
    /*! \fn This will generate a random nuber between two integer values. */
    public int m_RandomInt(int min, int max)
    {
        int l_iReturnValue = 0;

        l_iReturnValue = Random.Range(min, max); 

        return l_iReturnValue; 
    }
}
