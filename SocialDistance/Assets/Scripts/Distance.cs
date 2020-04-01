using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Distance : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField]
    GameObject m_camera;

    [SerializeField]
    GameObject sphere;

    [SerializeField]
    GameObject warning;

    [SerializeField]
    GameObject info;

    float distance = 0.0f;

    void Start()
    {
        warning.SetActive(false);
        info.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        distance = Vector3.Distance(m_camera.transform.position, sphere.transform.position);
        var rounded = Mathf.Round(distance * 100.0f) * 0.01f;
        if(distance < 2.0f)
        {
            warning.SetActive(true);
        }
        if(distance > 2.0f)
        {
            if(warning.activeSelf)
            {
                warning.SetActive(false);
                info.SetActive(true);
            }
            
        }
       
    }

    public void Switch()
    {
        info.SetActive(false);
    }

}
