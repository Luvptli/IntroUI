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
    bool tiempoCorriendo;

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
        tiempoCorriendo = false;
    }
    private void Update()
    {
        int minutos = Mathf.FloorToInt(time / 60F);
        int segundos = Mathf.FloorToInt(time % 60F);
        int centesimas = Mathf.FloorToInt((time * 60) % 60F);
        if (tiempoCorriendo)
        {
            time = time + Time.deltaTime;
            timeText.text = string.Format("{0:00}:{1:00}:{2:00}", minutos, segundos, centesimas);
        }
        

    }

    public void ButtonPause()
    {
        tiempoCorriendo = false;
        buttonStart.SetActive(true);
        buttonPause.SetActive(false);
        LeanTween.scale(buttonPause, Vector3.one * 0.9f, animTime).setOnComplete(() =>
        {
            LeanTween.scale(buttonPause, Vector3.one, animTime);
        });
    }

    public void ButtonStart()
    {
        tiempoCorriendo=true;
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
        tiempoCorriendo = false;
        timeText.text = time.ToString();
        LeanTween.scale(buttonRestart, Vector3.one * 0.9f, animTime).setOnComplete(() =>
        {
            LeanTween.scale(buttonRestart, Vector3.one, animTime);
        });
    }
}
