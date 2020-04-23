using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseChecker : MonoBehaviour
{
    bool isPaused = false;

    [SerializeField] GameObject m_pausedobj;
    [SerializeField] GameObject m_pausedfritz;
    
    void Update()
    {
        if(!isPaused)
        {
            m_pausedobj.SetActive(true);
            m_pausedfritz.SetActive(true);
        }
        else
        {
            m_pausedobj.SetActive(false);
            m_pausedfritz.SetActive(false);

        }
    }

    void OnApplicationFocus(bool hasFocus)
    {
        isPaused = !hasFocus;
    }

    void OnApplicationPause(bool pauseStatus)
    {
        isPaused = pauseStatus;
    }
}