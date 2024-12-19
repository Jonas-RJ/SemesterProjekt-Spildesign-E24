using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering.Universal;

public class TagFatMechanic : MonoBehaviour
{
    public PauseScreenManager _PSManager;
    public Timer _timer;
    public bool donutIsTaken = false;
    public bool donutIsEat = false;
    public bool canRun = false;

    public int Player1time;
    public int Player2time;


    public int Winningplayer;

    [SerializeField] private GameObject player1Light;
    [SerializeField] private GameObject player2Light;


    public GameObject Player1;  
    public GameObject Player2;

    [SerializeField] private bool _cop;
    [SerializeField] private bool _prisoner;

    public float coolDownTime = 5f;
    private float lastTimeUsed;

    public bool prisonerHasDonut = false;
    public bool copHasDonut = false;

    public AudioSource TouchingSound;

    

    // Start is called before the first frame update
    void Start()
    {
        player1Light.SetActive(false);
        player2Light.SetActive(false); 

        // Check hvilken player er hvilken. 
        if(gameObject.layer == 6) 
        
        {
            _cop = true;
            _prisoner = false;
        }


        if(gameObject.layer == 7) 
        {
            _cop = false;
            _prisoner = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Player1.tag == "HasDonut")
        {
            player1Light.SetActive(true);
            player2Light.SetActive(false);
        }
        if (Player2.tag == "HasDonut")
        {
            player2Light.SetActive(true);
            player1Light.SetActive(false);
 
        }
        // variable der checkes i update for at der opdateres for begge players
        if (donutIsEat)
        { 
            donutIsTaken=true;
          
        }
        
        // hvis den ene player har tagget HasDonut, gives NoDonut til den anden. To if statements, et for hver player.
        if (donutIsTaken && Player1.tag == "HasDonut") 
        {
            Player2.tag = "NoDonut"; 
        }
        if (donutIsTaken && Player2.tag == "HasDonut")
        {
            Player1.tag = "NoDonut";
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {

       // sætter donut til spist, deaktiverer donutten, giver et tag til den player der tager donutten. 
        if (other.gameObject.CompareTag("Donut") && gameObject == _cop)
        {
            other.gameObject.SetActive(false);
            donutIsEat = true;
            gameObject.tag = "HasDonut";
            _timer.canRun = true;

            // Disse to variabler eksisterer kun for at de kan blive brugt i MusicController scriptet til at spille lyden.
            prisonerHasDonut = false;
            copHasDonut = true;
        }
        if (other.gameObject.CompareTag("Donut") && gameObject == _prisoner)
        {
            other.gameObject.SetActive(false);
            donutIsEat = true;
            gameObject.tag = "HasDonut";
            _timer.canRun = true;

            prisonerHasDonut = true;
            copHasDonut = false;
        }

    }

   

    public void OnCollisionEnter2D(Collision2D col)
    {
        // Tjekker om det andet objekt har donutten og er cop plus tjekker om tiden NU er større end tiden sidst vi taggede plus cooldown tiden.
            if (col.gameObject.CompareTag("HasDonut") && _cop && Time.time > lastTimeUsed + coolDownTime)
            {
                // Do so that the other gameobject (the other player or the donut) loses the "HasDonut" tag.
                col.gameObject.tag = "NoDonut";
                gameObject.tag = "HasDonut";

                prisonerHasDonut = false;
                copHasDonut = true;

                TouchingSound.Play();

            // (Re)Start the timer
                lastTimeUsed = Time.time;
            }
            // Tjekker om det andet objekt ikke har donutten og er cop plus tjekker om tiden NU er større end tiden sidst vi taggede plus cooldown tiden.
            else if (col.gameObject.CompareTag("NoDonut") && _cop && Time.time > lastTimeUsed + coolDownTime)
            {
                col.gameObject.tag = "HasDonut";
                gameObject.tag = "NoDonut";

                prisonerHasDonut = true;
                copHasDonut = false;

                TouchingSound.Play();
                lastTimeUsed = Time.time;
            }
    }
}
