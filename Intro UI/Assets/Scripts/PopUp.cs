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
    }
     
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (popup.activeSelf)
            {
                ExitPopUp();
            }
            else
            {
                ShowPopUp();
            }
            
        }
    }

    public void ShowPopUp()
    {
        LeanTween.alphaCanvas(background.GetComponent<CanvasGroup>(), 1f, 0).setOnComplete(() =>
        {
            background.SetActive(true);
        });
        popup.SetActive(true);
        LeanTween.moveLocalY(popup, -900f, 0f);
        LeanTween.moveLocalY(popup, finalYPos, durationAnim).setEase(animCurve);
        
    }
    public void ExitPopUp()
    {
        LeanTween.moveLocalY(popup, -900f, durationAnim).setEase(animCurve).setOnComplete(() =>
        {
            popup.SetActive(false);
        });
        LeanTween.alphaCanvas(background.GetComponent<CanvasGroup>(), 0f, durationAnim).setOnComplete(() =>
        {
            background.SetActive(false);
        });
        
    }
}
