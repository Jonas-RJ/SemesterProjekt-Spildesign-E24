using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverScreen : MonoBehaviour
{
    public Text winnerText;
    public void Setup(int Winningplayer)
    {
        gameObject.SetActive(true);
        winnerText.text = Winningplayer.ToString() + " WINS!";
    }
    public void RestartButton()
    {
        SceneManager.LoadScene("Emil Scene"); //Burde være "Game Scene" i fremtiden
    }
    public void MainMenuButton()
    {
        //SceneManager.LoadScene("Main Menu Scene");
    }
}
