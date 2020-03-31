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
    Text txt;

    float distance = 0.0f;

    void Start()
    {
        txt.text = "d: " + distance.ToString() + " M";
    }

    // Update is called once per frame
    void Update()
    {
        
        distance = Vector3.Distance(m_camera.transform.position, sphere.transform.position);
        var rounded = Mathf.Round(distance * 100.0f) * 0.01f;
        if(distance < 2.0f)
        {
            txt.color = Color.red;
        }
        if(distance > 2.0f)
        {
            txt.color = Color.green;
        }
        txt.text = "distance " + rounded.ToString() + " M";
    }

}
