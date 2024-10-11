using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class AppSpace : MonoBehaviour
{
    [SerializeField]
    float time = 0f;

    [SerializeField]
    bool pulsetime;

    [SerializeField]
    TextMeshProUGUI timeText;

    void Start()
    {
        pulsetime = false;
    }

    // Update is called once per frame
    void Update()
    {
        int segundos = Mathf.FloorToInt(time % 60F);
        int centesimas = Mathf.FloorToInt((time * 60) % 60F); 

        if (pulsetime)
        {
           
            time = time + Time.deltaTime;
            timeText.text = string.Format("{0:00}:{1:00}", segundos, centesimas);
            if (Input.GetKeyDown(KeyCode.Space))
            {
                pulsetime = false;
            }
        }
        else
        {
            time = Time.deltaTime;
            if (Input.GetKeyDown(KeyCode.Space))
            {
                pulsetime = true;
            }
        }

    }
}
