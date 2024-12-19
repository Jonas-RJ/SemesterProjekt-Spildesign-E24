using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    //variable for the timer object
    public TextMeshProUGUI timerText1;
    public TextMeshProUGUI timerText2;
    //variable for the time
    public float remaining1Time;
    public float remaining2Time;
    public GameOverScreen GameOverScreen;
    public TagFatMechanic donuttag;
    public bool canRun = false;
    // Definerer en ny farve "orange"
    public Color orange = new Color(1.0f, 0.64f, 0.0f);

    public AudioSource eatDonut;

    // Update is called once per frame
    void Update()
    {
        
        if (canRun)
        {
            //if statement checks if timer reaches 0 and keeps it at 0 if it does
            if (remaining1Time > 0 && donuttag.Player1.tag == "HasDonut") //&& donut get == true
            {
                //Subtracts time from the remaingingTime variable
                remaining1Time -= Time.deltaTime;
            }
            //Hvis tid er lig med eller mindre end 0, kør indhold.
            else if (remaining1Time <= 0)
            {
                //Stops the timer when it reaches 0
                remaining1Time = 0;
                GameOverScreen.GameOver();
                //Display player wins for den spiller der vinder
            }

            //if statement checks if timer reaches 0 and keeps it at 0 if it does
            if (remaining2Time > 0 && donuttag.Player2.tag == "HasDonut") //&& donut get == true
            {
                //Subtracts time from the remaingingTime variable
                remaining2Time -= Time.deltaTime;
            }
            //Hvis tid er lig med eller mindre end 0, kør indhold.
            else if (remaining2Time <= 0)
            {
                //Stops the timer when it reaches 0
                remaining2Time = 0;
                GameOverScreen.GameOver();
                //Display player wins for den spiller der vinder
            }

            //Divides the number elapsed time into minutes and seconds
            int minutes1 = Mathf.FloorToInt(remaining1Time / 60);
            int seconds1 = Mathf.FloorToInt(remaining1Time % 60);
            //Formats the string to write "00:00" and input the variables in their respective order
            timerText1.text = string.Format("{0:00}:{1:00}", minutes1, seconds1);

            //Divides the number elapsed time into minutes and seconds
            int minutes2 = Mathf.FloorToInt(remaining2Time / 60);
            int seconds2 = Mathf.FloorToInt(remaining2Time % 60);
            //Formats the string to write "00:00" and input the variables in their respective order
            timerText2.text = string.Format("{0:00}:{1:00}", minutes2, seconds2);

            if (timerText1.text == "00:36" || timerText1.text == "00:31" || timerText1.text == "00:26" || timerText1.text == "00:21" ||
                timerText1.text == "00:16" || timerText1.text == "00:11" || timerText1.text == "00:06" || timerText1.text == "00:01")
            {
                eatDonut.Play();
            }

            if (timerText2.text == "00:36" || timerText2.text == "00:31" || timerText2.text == "00:26" || timerText2.text == "00:21" ||
                timerText2.text == "00:16" || timerText2.text == "00:11" || timerText2.text == "00:06" || timerText2.text == "00:01")
            {
                eatDonut.Play();
            }

        }


    }
}
