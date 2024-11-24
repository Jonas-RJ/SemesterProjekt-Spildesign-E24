using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicController : MonoBehaviour
{
    protected AudioSource startMusic;
    protected AudioSource Player1Music;
    protected AudioSource Player2Music;


    public GameObject Player1;
    public GameObject Player2;
    public TagFatMechanic TFScript;

    // Start is called before the first frame update
    void Start()
    {
        // Definerer TagFatMechanic scriptet for senere at kunne bruge donutIsEat variablen
        TFScript = Player1.GetComponent<TagFatMechanic>();

        startMusic = GetComponent<AudioSource>();
        startMusic.Play();
        startMusic.volume = 0.1f;
        

        Player1Music = Player1.GetComponent<AudioSource>();

        Player2Music = Player2.GetComponent<AudioSource>();

        Player1Music.Play();
        Player1Music.volume = 0;

        Player2Music.Play();
        Player2Music.volume = 0;
    }

    // Update is called once per frame
    void Update()
    {
        

        if (TFScript.donutIsEat == true)
        {
            startMusic.Stop();
        }

        // Baseret på disse 2 variabler, som bliver ændret inde i TagFatMechanic scriptet, spilles det rigtige soundtrack.
        if (TFScript.prisonerHasDonut == true)
        {
            Player1Music.volume = 0;
            Player2Music.volume = 0.1f;
        }
        if (TFScript.copHasDonut == true)
        {
            Player1Music.volume = 0.1f;
            Player2Music.volume = 0;
        }

    }
}
