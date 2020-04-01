using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealingCircle : MonoBehaviour
{
    [SerializeField] GameObject m_cameraobj;
    [SerializeField] Material m_circlematerial;
    [SerializeField] Distance m_distancechecker;
    
    void Update()
    {
        transform.position = new Vector3(m_cameraobj.transform.position.x, m_cameraobj.transform.position.y - 16, m_cameraobj.transform.position.z);

        if (m_distancechecker.RealLifeDistance < 2f)
        {
            m_circlematerial.color = new Color(255, 0, 0, 0.17f);
        }
        else
        {
            m_circlematerial.color = new Color(0, 255, 0, 0.17f);
        }
    }
}
