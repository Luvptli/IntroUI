using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeanTweenEjemplo : MonoBehaviour
{
    [SerializeField]
    float sizeToScale = 2f;

    [SerializeField]
    float durationAnim = 0.75f;

    [SerializeField]
    float finalYPos = 0.5f;
    void Start()
    {
        LeanTween.moveLocalY(gameObject, finalYPos, durationAnim).setEase(LeanTweenType.easeInOutElastic);
    }
     
    // Update is called once per frame
    void Update()
    {
        
    }
}
