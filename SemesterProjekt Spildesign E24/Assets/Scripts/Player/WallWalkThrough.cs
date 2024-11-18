using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallWalkThrough : MonoBehaviour
{

    [SerializeField] bool wallWalkReady = true;
    public float wallCD = 10;

    public GameObject Player2;
    public GameObject WallOpen;
    public GameObject WallClose;


    void Start(){}
    void Update(){}


    // efter man går ud af en væg, start coroutine
  /* void OnTriggerEnter2D(Collider2D other)
    {
        if (Player2.layer == 7)
        {
            print("ran through wall lmao");
            StartCoroutine(WallCoolDown());
        }
    }
  */

    private bool check1 = false;
    private bool check2 = false;

    private void OnTriggerExit2D(Collider2D collision)
    {
        print("Wall works now");
        Invoke("wallOpener", 0.1f);
        Invoke("wallShutter", 10f);
    }


    private void wallShutter() 
    {
     WallClose.SetActive(false);
     WallOpen.SetActive(true) ;
        print("wallshutter");
    }

    private void wallOpener()
    {
        WallOpen.SetActive(false);
        WallClose.SetActive(true);
        print("wall is open");
    }


  /*  public IEnumerator WallCoolDown()
    {

        // hvis ability er klar, gør intet
        if (wallWalkReady) { yield return null; }


        //
        wallWalkReady = false;
        Physics2D.IgnoreLayerCollision(3, 7, false) ;
        print("wall walked through");

        yield return new WaitForSeconds(wallCD);

        wallWalkReady = true;
        Physics2D.IgnoreLayerCollision(3, 7, true);
        print("ready again");

        
    }
  */
}
