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
        int horas = Mathf.FloorToInt(time / 3600F);
        int minutos = Mathf.FloorToInt(time / 60F);
        int segundos = Mathf.FloorToInt(time % 60F);
        int centesimas = Mathf.FloorToInt((time * 60) % 60F);

        /*float horas = time / 3600f;
        float restoHours = time % 3600f;
        int minutos = (int) restoHours / 60;
        float segundos = minutos % 60f;
        int centesimas = ((int)segundos - (int)segundos) * 1000;
        
        timeText.text= horas.ToString (00) + minutos.ToString (00) + segundos.ToString (00) + centesimas.ToString (00);
         */

        if (tiempoCorriendo)
        {
            time = time + Time.deltaTime;
            timeText.text = string.Format("{0:00}:{1:00}:{2:00}:{3:00}", horas, minutos, segundos, centesimas);
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
