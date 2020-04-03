using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CameraAccessScript : MonoBehaviour
{
    public GameObject NextView;
    public GameObject MindChangerView;

    public void Start()
    {
        Application.targetFrameRate = 60;

        if (PlayerPrefs.GetInt("hasConsent") == 1)
        {
            NextView.SetActive(true);
            gameObject.SetActive(false);
        }
    }

    // Start is called before the first frame update
    public void Nope()
    {
        MindChangerView.SetActive(true);
    }

    WebCamTexture webcamTexture;

    public void OK()
    {
        //webcamTexture = new WebCamTexture();
        //gameObject.AddComponent<MeshRenderer>().material.mainTexture = webcamTexture; //Add Mesh Renderer to the GameObject to which this script is attached to
        //webcamTexture.Play();
        //webcamTexture.Stop();

        foreach (var device in WebCamTexture.devices)
        {
            Debug.Log("Name: " + device.name);
        }

        StartCoroutine(co_OK());
    }
    private IEnumerator co_OK()
    {
        yield return Application.RequestUserAuthorization(UserAuthorization.WebCam);
        if (Application.HasUserAuthorization(UserAuthorization.WebCam))
        {
            PlayerPrefs.SetInt("hasConsent", 1);
            NextView.SetActive(true);
            gameObject.SetActive(false);
        }
        else
        {
            Nope();
        }
    }
}
