using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallWalkThrough : MonoBehaviour
{

    public float wallCD = 10;

    public GameObject Player2;
    public GameObject WallOpen;
    public GameObject WallClose;
    public AudioSource wallGoThrough;

    void Start(){}
    void Update()
    {
        
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
    //    print("Wall works now");

        Invoke("wallOpener", 0.1f);

        Invoke("wallShutter", 10f);


        wallGoThrough.Play();
        
        
    }


    private void wallShutter() 
    {
     WallClose.SetActive(false);
     WallOpen.SetActive(true) ;
        //print("wallshutter");
        
    }

    private void wallOpener()
    {
        WallOpen.SetActive(false);
        WallClose.SetActive(true);
       // print("wall is open");
    }


  
}
