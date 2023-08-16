using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement; 

public class GameManager : MonoBehaviour
{
    public float LimitTime;
    public TextMeshProUGUI text_Timer;

    public TextMeshProUGUI recordText;
    public GameObject UIGameoverBtn;
    public GameObject UIRestartBtn;

    public float Score;
    private bool isGameover;

    void Start()
    {
        Score = 0;
        isGameover = false;
    }

    void Update()
    {

        if (LimitTime <= 0)
        {
            EndGame();
        }

        if (!isGameover)
        {
  
            recordText.text = "Score: " + (int)Score;

            LimitTime -= Time.deltaTime;
            text_Timer.text = "Time : " + Mathf.Round(LimitTime);
        }

    }

    public void EndGame()
    {
        isGameover = true;
        UIGameoverBtn.SetActive(true);
        UIRestartBtn.SetActive(true);
    }

}
