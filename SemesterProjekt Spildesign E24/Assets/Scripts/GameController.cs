using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public float coolDownPeriod = 1.0f;
    public bool tagReady;
   // public bool coolDown;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

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

        if (tagReady) { yield return null;}

            tagReady = false;

            yield return new WaitForSeconds(coolDownPeriod);

            tagReady = true;
        }
    
}
