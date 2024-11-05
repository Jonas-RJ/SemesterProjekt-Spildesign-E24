using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallWalkThrough : MonoBehaviour
{

    [SerializeField] bool wallWalkReady;
    public float wallCD = 2;




    void Start(){}
    void Update(){}


    // efter man går ud af en væg, start coroutine
    void OnTriggerExit2D(Collider2D other)
    {
        
        print("ran through wall lmao");
        StartCoroutine(WallCoolDown());
    }




    public IEnumerator WallCoolDown()
    {

        // hvis ability er klar, gør intet
        if (wallWalkReady) { yield return null; }


        //
        wallWalkReady = false;
        Physics2D.IgnoreLayerCollision(3, 7, false) ;


        yield return new WaitForSeconds(wallCD);

        wallWalkReady = true;
        Physics2D.IgnoreLayerCollision(3, 7, true);

    }

}
