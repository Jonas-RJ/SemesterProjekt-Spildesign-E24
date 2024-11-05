using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class GameOverScreen : MonoBehaviour
{
    public Timer timer;
    public TagFatMechanic TFMechanic;
    public TextMeshProUGUI winnerText;
    public GameObject player1;
    public GameObject player2;
    int i;

    public void GameOver()
    {
        gameObject.SetActive(true);

        if (player1.tag == "HasDonut")
        {
            i = 1;
        }
        if (player2.tag == "HasDonut")
        {
            i = 2;
        }

        if (i == 1)
        {
            winnerText.text = "COP WINS!";
        }

        if (i == 2)
        {
            winnerText.text = "PRISONER WINS!";
        }

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
