using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseChecker : MonoBehaviour
{
    bool isPaused = false;

    [SerializeField] GameObject m_pausedobj;
    
    void Update()
    {
        Debug.Log(isPaused);

        if(!isPaused)
        {
            m_pausedobj.SetActive(true);
        }
        else
        {
            m_pausedobj.SetActive(false);
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
