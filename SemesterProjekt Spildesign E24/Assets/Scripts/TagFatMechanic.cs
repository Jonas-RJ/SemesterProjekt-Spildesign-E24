using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TagFatMechanic : MonoBehaviour
{
    public bool donutIsTaken = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Donut"))
        {
            other.gameObject.SetActive(false);
            donutIsTaken = true;
            gameObject.tag = "HasDonut";
            print("donutcollision");
        }
        
        if (other.gameObject.CompareTag("HasDonut") && donutIsTaken)
        {

            // Do so that the other gameobject (the other player or the donut) loses the "HasDonut" tag.
            gameObject.tag = "NoDonut";
            other.gameObject.tag = "HasDonut";

            // (Re)Start the timer

            // Change sprite to a sprite where the player holds the donut

        }

        
    }

    
}
