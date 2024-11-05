using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    //variable for the timer object
    [SerializeField] TextMeshProUGUI timerText;
    //variable for the time
    public float remainingTime;
    public GameOverScreen GameOverScreen;
    
    // Update is called once per frame
    void Update()
    {
        //if statement checks if timer reaches 0 and keeps it at 0 if it does
        if (remainingTime > 0) //&& donut get == true
        {
            //Subtracts time from the remaingingTime variable
            remainingTime -= Time.deltaTime;
        }
        //Endnu et if statement indeni til hvis timeren skal reset hvis den anden player tager donut?
        else if (remainingTime <= 0)
        {
            //Stops the timer when it reaches 0 and turns it green
            remainingTime = 0;
            GameOverScreen.GameOver();
            timerText.color = Color.green;
            //Display player wins for den spiller der vinder
        }

        //Divides the number elapsed time into minutes and seconds
        int minutes = Mathf.FloorToInt(remainingTime / 60);
        int seconds = Mathf.FloorToInt(remainingTime % 60);
        //Formats the string to write "00:00" and input the variables in their respective order
        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }

}
