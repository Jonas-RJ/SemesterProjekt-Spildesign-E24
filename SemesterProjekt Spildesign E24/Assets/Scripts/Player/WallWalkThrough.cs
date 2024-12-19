using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallWalkThrough : MonoBehaviour
{

    public float wallCD = 10;

    public GameObject WallOpen;
    public GameObject WallClose;
    public AudioSource wallGoThrough;


    private void OnTriggerExit2D(Collider2D collision)
    {
        //invoke to be able to call after X amount of time.
        Invoke("wallCloser", 0.1f);

        Invoke("wallOpener", wallCD);


        wallGoThrough.Play();
    }


    private void wallOpener() 
    {
        //disables red wall, enables green
     WallClose.SetActive(false);
     WallOpen.SetActive(true) ;        
    }

    private void wallCloser()
    {
        //enables red closed wall, disables green open wall
        WallOpen.SetActive(false);
        WallClose.SetActive(true);
    }
}
