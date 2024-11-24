using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HowToPlay : MonoBehaviour
{
    //Loader vores spil scene ved tryk af backknappen som vi giver denne method
    public void BackButton()
    {
        SceneManager.LoadScene("Main Menu Scene");
    }

}
