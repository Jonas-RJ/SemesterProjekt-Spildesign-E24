using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerSpriteChanger : MonoBehaviour
{
    public Timer Timer1;
    public Timer Timer2;

    // Definer alle SpriteObjekterne

    public Image copBar1;
    public Image copBar2;
    public Image copBar3;
    public Image copBar4;
    public Image copBar5;
    public Image copBar6;
    public Image copBar7;
    public Image copBar8;
    public Image copBar9;

    public Image prisonerBar1;
    public Image prisonerBar2;
    public Image prisonerBar3;
    public Image prisonerBar4;
    public Image prisonerBar5;
    public Image prisonerBar6;
    public Image prisonerBar7;
    public Image prisonerBar8;
    public Image prisonerBar9;

    

    // Start is called before the first frame update
    void Start()
    {
        copBar1.gameObject.SetActive(true);
        prisonerBar1.gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (Timer1.timerText1.text == "00:36")
        {
            // Set sprite
            copBar2.gameObject.SetActive(true);
            copBar1.gameObject.SetActive(false);
        }
        if (Timer1.timerText1.text == "00:31")
        {
            // Set sprite
            copBar3.gameObject.SetActive(true);
            copBar2.gameObject.SetActive(false);
        }
        if (Timer1.timerText1.text == "00:26")
        {
            // Set sprite
            copBar4.gameObject.SetActive(true);
            copBar3.gameObject.SetActive(false);
        }
        if (Timer1.timerText1.text == "00:21")
        {
            // Set sprite
            copBar5.gameObject.SetActive(true);
            copBar4.gameObject.SetActive(false);
        }
        if (Timer1.timerText1.text == "00:16")
        {
            // Set sprite
            copBar6.gameObject.SetActive(true);
            copBar5.gameObject.SetActive(false);
        }
        if (Timer1.timerText1.text == "00:11")
        {
            // Set sprite
            copBar7.gameObject.SetActive(true);
            copBar6.gameObject.SetActive(false);
        }
        if (Timer1.timerText1.text == "00:06")
        {
            // Set sprite
            copBar8.gameObject.SetActive(true);
            copBar7.gameObject.SetActive(false);
        }
        if (Timer1.timerText1.text == "00:01")
        {
            // Set sprite
            copBar9.gameObject.SetActive(true);
            copBar8.gameObject.SetActive(false);
        }






        if (Timer2.timerText1.text == "00:36")
        {
            // Set sprite
            prisonerBar2.gameObject.SetActive(true);
            prisonerBar1.gameObject.SetActive(false);
        }
        if (Timer2.timerText1.text == "00:31")
        {
            // Set sprite
            prisonerBar3.gameObject.SetActive(true);
            prisonerBar2.gameObject.SetActive(false);
        }
        if (Timer2.timerText1.text == "00:26")
        {
            // Set sprite
            prisonerBar4.gameObject.SetActive(true);
            prisonerBar3.gameObject.SetActive(false);
        }
        if (Timer2.timerText1.text == "00:21")
        {
            // Set sprite
            prisonerBar5.gameObject.SetActive(true);
            prisonerBar4.gameObject.SetActive(false);
        }
        if (Timer2.timerText1.text == "00:16")
        {
            // Set sprite
            prisonerBar6.gameObject.SetActive(true);
            prisonerBar5.gameObject.SetActive(false);
        }
        if (Timer2.timerText1.text == "00:11")
        {
            // Set sprite
            prisonerBar7.gameObject.SetActive(true);
            prisonerBar6.gameObject.SetActive(false);
        }
        if (Timer2.timerText1.text == "00:06")
        {
            // Set sprite
            prisonerBar8.gameObject.SetActive(true);
            prisonerBar7.gameObject.SetActive(false);
        }
        if (Timer2.timerText1.text == "00:01")
        {
            // Set sprite
            prisonerBar9.gameObject.SetActive(true);
            prisonerBar8.gameObject.SetActive(false);
        }
    }


}
