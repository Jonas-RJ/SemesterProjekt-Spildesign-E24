using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class DashTest : MonoBehaviour
{
    public float dashSpeed = 10f;
    public float dashDuration = 1f;
    public float dashCooldown = 3f;
    public bool isDashing;
    bool canDash = true;
    public float moveSpeed = 10f;

    private Vector3 movementInput;

    private Rigidbody2D rb;
    public GameObject Player1;
    public GameObject Player2;
    
    // Start is called before the first frame update
    void Start()
    {
    }
    
    // Update is called once per frame
    void Update()
    {
                    rb = GetComponent<Rigidbody2D>();

        if (this.gameObject.tag == "HasDonut")
        {
            canDash = true;
        }


        if (isDashing)
        {
           // print("im dashing ");
            return;
        }
        rb.velocity = new Vector2(movementInput.x * moveSpeed, movementInput.y * moveSpeed); 
    }

    public void OnFire(InputValue inputValue)
    {
        Debug.Log("Pressed Dash Button");

        if (canDash)
        {
            print("can dash available");
            StartCoroutine(Dash());
        }
    }



    private IEnumerator Dash()
    {
        canDash = false; // Sets can dash to false, so as to prevent spam dashing
        isDashing = true; // Sets isdashing to true, as we are currently running the code for dashing
        rb.velocity = new Vector2(movementInput.x * dashSpeed, movementInput.y * dashSpeed); // Updates the speed of player, as to simulate a dash
        yield return new WaitForSeconds(dashDuration); // After the dash duration, removes the above speed changes, so as to go back to normal
        isDashing = false; // As we are no longer dashing, we set it to false (for animation reasons later?)
        //capsuleCollider.isTrigger = false;
        yield return new WaitForSeconds(dashCooldown); // We then wait for the desired cooldown time
        canDash = true; // And finally we set canDash to true, so we can dash from the start again.

        print("coroutine started");
    }


}
    
