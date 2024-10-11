using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class AppSpace2 : MonoBehaviour
{
    [SerializeField]
    float time = 15f;

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


    void Start()
    {
        
    }

    void Update()
    {
        timeText.text = time.ToString();
        nPulsaciones.text = pulsaciones.ToString();
        pulsacionesMin.text = pMin.ToString();
    }
}
