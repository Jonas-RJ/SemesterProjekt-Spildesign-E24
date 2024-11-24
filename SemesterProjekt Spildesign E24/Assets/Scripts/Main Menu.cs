using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    //Loader vores spil scene
    public void PlayButton()
    {
        SceneManager.LoadScene("GameTestScene"); //Burde være "Game Scene" i fremtiden
    }

    //Loader Main Menu scene
    public void HowToPlayButton()
    {
        SceneManager.LoadScene("How To Play Scene");
    }
}
