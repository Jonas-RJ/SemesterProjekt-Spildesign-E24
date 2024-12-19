using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class PauseScreenManager : MonoBehaviour
{
    [SerializeField] GameObject Pausemenu;

    public void Pause()
    {
        Pausemenu.SetActive(true);
        Time.timeScale = 0f;
    }


    //Starter spillet igen ved tryk af continue button
    public void ContinueButton()
    {
        Pausemenu.SetActive(false);
        Time.timeScale = 1f;
    }

    //Loader vores spil scene ved tryk af restart knap som vi giver denne method
    public void RestartButton()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("GameTestScene");
    }

    //Loader Main Menu scene ved tryk af knap som vi giver denne method
    public void MainMenuButton()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Main Menu Scene");
    }


    /*public void Pause()
    {
        gameObject.SetActive(true);
        Time.timeScale = 0;
        Debug.Log("Debug should pop up");
    }*/



    /*public void gamePaused()
    {
        gameObject.SetActive(true);
        Time.timeScale = 0;
        Debug.Log("If statement virker");
    }

    public void gameResumed()
    {
        gameObject.SetActive(false);
        Time.timeScale = 1;
    }*/
}
