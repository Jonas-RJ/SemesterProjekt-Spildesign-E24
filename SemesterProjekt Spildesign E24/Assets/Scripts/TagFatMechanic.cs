using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering.Universal;






public class TagFatMechanic : MonoBehaviour
{
    public Timer _timer;
    public GameController GCcooldown;
    public bool donutIsTaken = false;
    public bool donutIsEat = false;
    public bool canRun = false;

    public int Player1time;
    public int Player2time;


    public int Winningplayer;

    [SerializeField] private Light2D player1Light;
    [SerializeField] private Light2D player2Light;
    [SerializeField] private Light2D lightsUniversal;


    public GameObject Player1;  
    public GameObject Player2;

    [SerializeField] private bool _cop;
    [SerializeField] private bool _prisoner;

    public float coolDownTime = 5f;
    private float lastTimeUsed;

    // Start is called before the first frame update
    void Start()
    {
        player1Light = GetComponent<Light2D>();
        player2Light = GetComponent<Light2D>();
        lightsUniversal = GetComponent<Light2D>();


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

       // s�tter donut til spist, deaktiverer donutten, giver et tag til den player der tager donutten. 
        if (other.gameObject.CompareTag("Donut"))
        {
            other.gameObject.SetActive(false);
            donutIsEat = true;
            gameObject.tag = "HasDonut";
            print("donutcollision");
            _timer.canRun = true;
          //  lightsUniversal.enabled = false;
            /* */
        }
        
   
        


        /*
        if (other.gameObject.CompareTag("NoDonut"))
        {
            gameObject.tag = "NoDonut";
            other.gameObject.tag = "HasDonut";


        }
        */



    }
    


    public void OnCollisionEnter2D(Collision2D col)
    {

        // if (GCcooldown.tagReady)
        // {
            //print("hej:3");
        // Tjekker om det andet objekt har donutten og er cop plus tjekker om tiden NU er større end tiden sidst vi taggede plus cooldown tiden.
            if (col.gameObject.CompareTag("HasDonut") && _cop && Time.time > lastTimeUsed + coolDownTime)
            {

                // Do so that the other gameobject (the other player or the donut) loses the "HasDonut" tag.
                col.gameObject.tag = "NoDonut";
                gameObject.tag = "HasDonut";


                print("1");

            // (Re)Start the timer

            // Change sprite to a sprite where the player holds the donut
            //   StartCoroutine(GCcooldown.startCooldown());

                lastTimeUsed = Time.time;
            }
            // Tjekker om det andet objekt ikke har donutten og er cop plus tjekker om tiden NU er større end tiden sidst vi taggede plus cooldown tiden.
            else if (col.gameObject.CompareTag("NoDonut") && _cop && Time.time > lastTimeUsed + coolDownTime)
            {
                col.gameObject.tag = "HasDonut";
                gameObject.tag = "NoDonut";

                print("2");
                lastTimeUsed = Time.time;

            if (GCcooldown.tagReady) { }
            }
        //}
        
            
    }
}
