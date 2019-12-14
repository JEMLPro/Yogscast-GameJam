using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField]
    float m_fSpeed = 25.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float l_fYTranslation = (Input.GetAxis("Vertical") * m_fSpeed) * Time.deltaTime;

        float l_fXTranslation = (Input.GetAxis("Horizontal") * m_fSpeed) * Time.deltaTime;

        transform.Translate(l_fXTranslation, l_fYTranslation, 0);
    }
}
