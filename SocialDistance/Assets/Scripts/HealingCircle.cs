using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealingCircle : MonoBehaviour
{
    [SerializeField] GameObject m_cameraobj;
    
    void Update()
    {
        transform.position = new Vector3(m_cameraobj.transform.position.x, m_cameraobj.transform.position.y - 16, m_cameraobj.transform.position.z); 
    }
}
