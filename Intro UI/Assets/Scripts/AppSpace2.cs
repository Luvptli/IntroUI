using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class AppSpace2 : MonoBehaviour
{
    [SerializeField]
    float time = 15;

    [SerializeField]
    float resta = 0;

    [SerializeField]
    float pulsaciones = 0;

    [SerializeField]
    float pMin = 0;

    [SerializeField]
    TextMeshProUGUI timeText;

    [SerializeField]
    TextMeshProUGUI nPulsaciones;

    [SerializeField]
    TextMeshProUGUI pulsacionesMin;

    [SerializeField]
    bool tiempoCorre;


    void Start()
    {
        tiempoCorre = false;
    }

    void Update()
    {
        timeText.text = time.ToString();
        nPulsaciones.text = pulsaciones.ToString();
        pulsacionesMin.text = pMin.ToString();
        float segundos = Mathf.FloorToInt(time % 60f);
        float centesimas = Mathf.FloorToInt((time * 60) % 60f);
        time -= Time.deltaTime;
        timeText.text = string.Format("{0:00}:{1:00}", segundos, centesimas);


    }
}

        /*if (tiempoCorre)
        {
            float segundos = Mathf.FloorToInt(time % 60f);
            float centesimas = Mathf.FloorToInt((time * 60) % 60f);
            if (time > 0)
            {
                time -= Time.deltaTime;
                timeText.text = string.Format("{0:00}:{1:00}", segundos, centesimas);
            }
            if (time == 0)
            {
                timeText.text = string.Format("{0:00}:{1:00}", segundos, centesimas);
                Debug.Log("Se acabó el tiempo");

                tiempoCorre = false;
                
            }
        }
       
        else
        {
            
            if (Input.GetKeyDown(KeyCode.Space))
            { 
                tiempoCorre = true;
            }
        }
       
    }
}*/
