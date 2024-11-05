using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public float coolDownPeriod = 1.0f;
    public bool tagReady;
    public Coroutine tagCD;
    public bool firstTag;
   // public bool coolDown;


    // Start is called before the first frame update
    void Start()
    {
        tagReady = true;
    }

    // Update is called once per frame
   public void FixedUpdate()
    {
        if (tagReady) 
        {
            StartCoroutine(startCooldown());
        }
                

    }

    /*
    public void tagCooldown()
    {
        if (!coolDown)
        {

        }
    }
    */
    public IEnumerator startCooldown() 
         {

        //if (tagReady) { yield return null; }
        //else
        //    {
            tagReady = false;

            yield return new WaitForSeconds(coolDownPeriod);

            tagReady = true;
        //    }
        }
    
}
