using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballMove : MonoBehaviour
{
 
    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Target")
        {

            other.gameObject.SetActive(false);

            //Point
            bool isGreen = other.gameObject.name.Contains("Green");
            bool isBlue = other.gameObject.name.Contains("Blue");
            bool isRed = other.gameObject.name.Contains("Red");
            bool isYellow = other.gameObject.name.Contains("Yellow");

            GameManager gameManager = FindObjectOfType<GameManager>();

            if (isGreen)
                gameManager.Score += 10;
            else if (isBlue)
                gameManager.Score += 30;
            else if (isRed)
                gameManager.Score += 50;
            else if (isYellow)
                gameManager.Score += 100;
        }
    }
}