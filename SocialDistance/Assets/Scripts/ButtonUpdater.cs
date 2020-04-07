using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DanielLochner.Assets.SimpleScrollSnap;
using TMPro;

public class ButtonUpdater : MonoBehaviour
{
    public UnityEngine.UI.Button nextButton;
    public string nextSceneName;

    public void PageChanged()
    {
        var textMesh = nextButton.GetComponentInChildren<TextMeshProUGUI>();
        SimpleScrollSnap simpleScrollSnap = GetComponent<SimpleScrollSnap>();
        if (simpleScrollSnap.TargetPanel == simpleScrollSnap.NumberOfPanels - 1)
        {
            textMesh.text = "Start";
        } else
        {
            textMesh.text = "Next";
        }
    }

    public void NextOrStart()
    {
        SimpleScrollSnap simpleScrollSnap = GetComponent<SimpleScrollSnap>();
        if (simpleScrollSnap.CurrentPanel == simpleScrollSnap.NumberOfPanels - 1)
        {
            Skip();
        } else
        {
            simpleScrollSnap.GoToNextPanel();
        }
    }

    public void Skip()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(nextSceneName);
    }
}
