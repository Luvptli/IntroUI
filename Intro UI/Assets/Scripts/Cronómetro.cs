using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Cronómetro : MonoBehaviour
{
    [SerializeField]
    float time = 0;

    [SerializeField]
    TextMeshProUGUI timeText;

    [SerializeField]
    GameObject buttonStart;
    [SerializeField]
    GameObject buttonPause;
    [SerializeField]
    GameObject buttonRestart;

    [SerializeField]
    float animTime = 5f;

    private void Start()
    {
        buttonPause.SetActive(false);
    }
    private void Update()
    {
            time = time + Time.deltaTime;
            timeText.text = time.ToString();
    }

    public void ButtonPause()
    {
        buttonStart.SetActive(true);
        buttonPause.SetActive(false);
        LeanTween.scale(buttonPause, Vector3.one * 0.9f, animTime).setOnComplete(() =>
        {
            LeanTween.scale(buttonPause, Vector3.one, animTime);
        });
    }

    public void ButtonStart()
    {
        buttonStart.SetActive(false);
        buttonPause.SetActive(true);
        LeanTween.scale(buttonStart, Vector3.one * 0.9f, animTime).setOnComplete(() =>
        {
            LeanTween.scale(buttonStart, Vector3.one, animTime);
        });
    }
    public void ButtonRestart()
    {
        time = 0;
        LeanTween.scale(buttonRestart, Vector3.one * 0.9f, animTime).setOnComplete(() =>
        {
            LeanTween.scale(buttonRestart, Vector3.one, animTime);
        });
    }
}
