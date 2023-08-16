using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Timer : MonoBehaviour
{

    public float LimitTime;
    public TextMeshProUGUI text_Timer;

    void Update()
    {
        LimitTime -= Time.deltaTime;
        text_Timer.text = "Time : " + Mathf.Round(LimitTime);
    }
}
