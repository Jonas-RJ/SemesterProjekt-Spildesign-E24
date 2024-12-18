using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class GameOverScreen : MonoBehaviour
{
    public Timer _timer;
    public TagFatMechanic TFMechanic;
    public TextMeshProUGUI winnerText;
    public GameObject player1;
    public GameObject player2;
    int i;




    //Checker hvem der har Donutten for at kunne skrive hvem der har vundet
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

    //Loader vores spil scene ved tryk af restart knap som vi giver denne method
    public void RestartButton()
    {
        SceneManager.LoadScene("GameTestScene");
        
    }
    //Loader Main Menu scene ved tryk af knap som vi giver denne method
    public void MainMenuButton()
    {
        SceneManager.LoadScene("Main Menu Scene");
    }
}
