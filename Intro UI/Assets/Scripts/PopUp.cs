using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopUp : MonoBehaviour
{
    [SerializeField]
    GameObject background;
    [SerializeField]
    GameObject popup;

    [SerializeField]
    float finalYPos = 0.5f;
    [SerializeField]
    float durationAnim = 0.75f;
    [SerializeField]
    LeanTweenType animCurve;

    private void Start()
    {
        background.SetActive(false);
        popup.SetActive(false);
        LeanTween.moveLocalY(popup, finalYPos, durationAnim).setEase(animCurve);
    }
     
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            background.SetActive(true);
            popup.SetActive(true);
        }
    }
}
