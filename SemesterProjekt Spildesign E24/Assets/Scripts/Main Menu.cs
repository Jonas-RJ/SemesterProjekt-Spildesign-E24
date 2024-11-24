using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    //Loader vores spil scene ved tryk af knap som vi giver denne method
    public void PlayButton()
    {
        SceneManager.LoadScene("GameTestScene"); //Burde være "Game Scene" i fremtiden
    }

    //Loader Main Menu scene ved tryk af knap som vi giver denne method
    public void HowToPlayButton()
    {
        SceneManager.LoadScene("How To Play Scene");
    }
}
