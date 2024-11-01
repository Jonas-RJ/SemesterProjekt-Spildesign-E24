using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverScreen : MonoBehaviour
{
    public Text winnerText;
    public void Setup(string player)
    {
        gameObject.SetActive(true);
        winnerText.text = player.ToString() + " WINS!";
    }
    public void RestartButton()
    {
        SceneManager.LoadScene("Emil Scene");
    }
    public void MainMenuButton()
    {
        //SceneManager.LoadScene("Main Menu Scene");
    }
}
