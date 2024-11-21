using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    //variable for the timer object
    [SerializeField] TextMeshProUGUI timerText1;
    [SerializeField] TextMeshProUGUI timerText2;
    //variable for the time
    public float remaining1Time;
    public float remaining2Time;
    public GameOverScreen GameOverScreen;
    public TagFatMechanic donuttag;
    public bool canRun = false;
    // Definerer en ny farve "orange"
    public Color orange = new Color(1.0f, 0.64f, 0.0f);

    // Update is called once per frame
    void Update()
    {
        
        if (canRun)
        {
            // Starter med at give de to timere en farve der matcher spillerfarven
            timerText1.color = Color.blue;
            timerText2.color = orange;

            //if statement checks if timer reaches 0 and keeps it at 0 if it does
            if (remaining1Time > 0 && donuttag.Player1.tag == "HasDonut") //&& donut get == true
            {
                //Subtracts time from the remaingingTime variable
                remaining1Time -= Time.deltaTime;
            }
            //Endnu et if statement indeni til hvis timeren skal reset hvis den anden player tager donut?
            else if (remaining1Time <= 0)
            {
                //Stops the timer when it reaches 0 and turns it green
                remaining1Time = 0;
                GameOverScreen.GameOver();
                timerText1.color = Color.green;
                timerText2.color = Color.red;
                //Display player wins for den spiller der vinder
            }

            //if statement checks if timer reaches 0 and keeps it at 0 if it does
            if (remaining2Time > 0 && donuttag.Player2.tag == "HasDonut") //&& donut get == true
            {
                //Subtracts time from the remaingingTime variable
                remaining2Time -= Time.deltaTime;
            }
            //Endnu et if statement indeni til hvis timeren skal reset hvis den anden player tager donut?
            else if (remaining2Time <= 0)
            {
                //Stops the timer when it reaches 0 and turns it green
                remaining2Time = 0;
                GameOverScreen.GameOver();
                timerText2.color = Color.green;
                timerText1.color = Color.red;
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
        }

    }
}
