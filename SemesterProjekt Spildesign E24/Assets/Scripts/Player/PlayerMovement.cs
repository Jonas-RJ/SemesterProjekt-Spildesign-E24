using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{

    //dash settings. We multiply normal move speed by a bonus, and keep a variable that contains the old move speed to change back to
    //we keep gameobjects for the players to be able to refer to them, and only enable dash for one at a time. 
    [SerializeField] private float _dashMoveSpeed;
    [SerializeField] private float _dashDuration;
    [SerializeField] private float _dashCooldown;
    [SerializeField] private float _originalMoveSpeed;
    public bool isDashing;
    public bool _p1CanDash = false;
    public GameObject Player1;
    public GameObject Player2;


    [SerializeField] private float _moveSpeed;
    [SerializeField] private float _rotationSpeed;

    private Rigidbody2D _rb;



    private Vector2 _movementInput;
    private Vector2 _smoothedMoveInput;
    private Vector2 _smoothMoveVelocity;
    private Animator _animator;

    public AudioSource dashSound;


    [SerializeField] private TrailRenderer dashTrail;
    // private float waitTime;

    public AudioSource walkSound;


    private void Awake()
    {
       _rb = GetComponent<Rigidbody2D>();
       dashTrail = GetComponent<TrailRenderer>();
       _p1CanDash = false;
        _animator = GetComponent<Animator>();
    }

    public void SetAnimation()
    {
        bool isMoving = _movementInput != Vector2.zero;
        _animator.SetBool("IsMoving", isMoving);
        
    }
    private void Update()
    {
        if (Player1.tag == "NoDonut")
        {
            _p1CanDash = true;
        }  
        if (Player1.tag == "HasDonut")
        {
            _p1CanDash = false;
        }
        
        if (isDashing)
        {
            // print("im dashing ");
            return;
        }
    }

    private void FixedUpdate()
    {
       
        SetPlayerVelocity();
        RotateInDirectionOfInput();
        SetAnimation();
        

    }

    private void SetPlayerVelocity()
    {
        //create a new smoothened vector that makes movement nicer and less janky


        //vector starts from zero and gradually moves up 
        _smoothedMoveInput = Vector2.SmoothDamp(_smoothedMoveInput, _movementInput, ref _smoothMoveVelocity, 0.1f);


        //set velocity with smoothed vector movement and movespeed variable.
        _rb.velocity = _smoothedMoveInput * _moveSpeed;
    }

    private void RotateInDirectionOfInput()
    {
        if (_movementInput != Vector2.zero)
        {

            Quaternion targetRotation = Quaternion.LookRotation(transform.forward, _smoothedMoveInput);
            Quaternion rotation = Quaternion.RotateTowards(transform.rotation, targetRotation, _rotationSpeed * Time.deltaTime);


            _rb.MoveRotation(rotation);      
        
        }
    }

    public void OnFire(InputValue inputValue)
    {
        Debug.Log("Pressed Dash Button");

        if (_p1CanDash)
        {
            print("can dash player 1 available");
            StartCoroutine(Dash1());
            dashSound.Play();
        }
        
      
    }

    private IEnumerator Dash1()
    {
        _p1CanDash = false; // Sets can dash to false, so as to prevent spam dashing
        isDashing = true; // Sets isdashing to true, as we are currently running the code for dashing
        _moveSpeed += _dashMoveSpeed; // multiply here
        yield return new WaitForSeconds(_dashDuration); // After the dash duration, removes the above speed changes, so as to go back to normal
        _moveSpeed = _originalMoveSpeed;
        isDashing = false; // As we are no longer dashing, we set it to false (for animation reasons later?)
        yield return new WaitForSeconds(_dashCooldown); // We then wait for the desired cooldown time
        _p1CanDash = true; // And finally we set canDash to true, so we can dash from the start again.

        print("Player 1 dashed");
    }
    
    private void OnMove(InputValue inputValue)
    {
      _movementInput =  inputValue.Get<Vector2>();
        walkSound.Play();
    }


    /*
    private void OnFire(InputValue inputValue)
    {
      
        Debug.Log("Pressed Dash Button");
        
    }

    */

}
