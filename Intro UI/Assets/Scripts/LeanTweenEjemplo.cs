using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeanTweenEjemplo : MonoBehaviour
{
    [SerializeField]
    float durationAnim = 0.75f;

    [SerializeField]
    float finalYPos = 0.5f;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            LeanTween.moveLocalY(gameObject, finalYPos, durationAnim).setEase(LeanTweenType.easeInOutElastic).setOnComplete(() =>
            {
                LeanTween.moveLocalX(gameObject, finalYPos, durationAnim).setEase(LeanTweenType.easeInOutElastic).setOnComplete(() =>
                {
                    LeanTween.moveLocalY(gameObject, -finalYPos, durationAnim).setEase(LeanTweenType.easeInOutElastic).setOnComplete(() =>
                    {
                        LeanTween.moveLocalX(gameObject, -finalYPos, durationAnim).setEase(LeanTweenType.easeInOutElastic);
                    });
                });
            });

        }
    }
}
