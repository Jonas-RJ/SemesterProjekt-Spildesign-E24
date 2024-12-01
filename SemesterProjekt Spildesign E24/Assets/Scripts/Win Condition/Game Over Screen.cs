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

    [SerializeField] private int mapSelector;

    public GameObject emilMap;
    public GameObject martinMap;
    public GameObject kenniMap;
    public GameObject lucasMap;
    public GameObject jonasMap;

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
        //SceneManager.LoadScene("GameTestScene");
        mapSelector = Random.Range(0, 5);
        print(mapSelector);
        gameObject.SetActive(false);
        switch (mapSelector)
        {
            case 0:
                emilMap.SetActive(false);
                kenniMap.SetActive(false);
                martinMap.SetActive(false);
                lucasMap.SetActive(false);
                jonasMap.SetActive(true);
                break;
            case 1:
                emilMap.SetActive(false);
                kenniMap.SetActive(false);
                martinMap.SetActive(false);
                lucasMap.SetActive(true);
                jonasMap.SetActive(false);
                break;
            case 2:
                emilMap.SetActive(false);
                kenniMap.SetActive(false);
                martinMap.SetActive(true);
                lucasMap.SetActive(false);
                jonasMap.SetActive(false);
                break;
            case 3:
                emilMap.SetActive(false);
                kenniMap.SetActive(true);
                martinMap.SetActive(false);
                lucasMap.SetActive(false);
                jonasMap.SetActive(false);
                break;
            case 4:
                emilMap.SetActive(true);
                kenniMap.SetActive(false);
                martinMap.SetActive(false);
                lucasMap.SetActive(false);
                jonasMap.SetActive(false);
                break;
        }
    }
    //Loader Main Menu scene ved tryk af knap som vi giver denne method
    public void MainMenuButton()
    {
        SceneManager.LoadScene("Main Menu Scene");
    }
}
