using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Incrementar : MonoBehaviour
{
    [SerializeField]
    int incrementar;

    [SerializeField]
    TextMeshProUGUI contador;

    [SerializeField]
    float animTime = 0.5f;

    [SerializeField]
    GameObject text;

    [SerializeField]
    GameObject button;

    void Start()
    {
    }

    void Update()
    {

    }
    public void ButtonTouch()
    {
        incrementar++;
        contador.text = incrementar.ToString();
        LeanTween.scale(text, Vector3.one * 0.5f, animTime).setOnComplete(() =>
          {
              LeanTween.scale(text, Vector3.one, animTime);
          });
        LeanTween.moveLocalY(button, 390f, animTime).setOnComplete(() =>
        {
            LeanTween.moveLocalY(button, 356.62f, animTime);
        });
    }
    public void Button2Touch()
    {
        incrementar++;
        contador.text = incrementar.ToString();
        LeanTween.scale(text, Vector3.one * 0.5f, animTime).setOnComplete(() =>
        {
            LeanTween.scale(text, Vector3.one, animTime);
        });
        LeanTween.moveLocalY(button, 390f, animTime).setOnComplete(() =>
        {
            LeanTween.moveLocalY(button, 356.62f, animTime);
        });
    }
}
