using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveNDash : MonoBehaviour
{
    private const float MOVE_SPEED = 5f;

    [SerializeField] private LayerMask dashLayerMask;
    private Rigidbody2D rb;
    private Vector3 moveDir;
    private bool isDashButtonDown;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        float moveX = 0f;
        float moveY = 0f;

        if (Input.GetKey(KeyCode.W))
        {
            moveY = +1f;
        }
        if (Input.GetKey(KeyCode.S))
        {
            moveY = -1f;
        }
        if (Input.GetKey(KeyCode.A))
        {
            moveX = -1f;
        }
        if (Input.GetKey(KeyCode.D))
        {
            moveX = +1f;
        }

        // normalized is so when we go diagonal it isn't too fast
        moveDir = new Vector3(moveX, moveY).normalized;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            isDashButtonDown = true;
        }
    }

    private void FixedUpdate()
    {
        rb.velocity = moveDir * MOVE_SPEED;

        if (isDashButtonDown)
        {
            float dashAmount = 3f;
            Vector3 dashPosition = transform.position + moveDir * dashAmount;

            RaycastHit2D raycastHit2d = Physics2D.Raycast(transform.position, moveDir, dashAmount, dashLayerMask);
            if (raycastHit2d.collider != null)
            {
                dashPosition = raycastHit2d.point;
            }

            rb.MovePosition(transform.position + moveDir * dashAmount);
            isDashButtonDown = false;
        }
    }
}
