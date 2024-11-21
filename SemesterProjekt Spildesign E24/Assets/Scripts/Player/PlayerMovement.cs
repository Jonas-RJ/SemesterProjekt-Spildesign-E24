using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{

    [SerializeField] private float _moveSpeed;
    [SerializeField] private float _rotationSpeed;

    private Rigidbody2D _rb;
    private Animator _animator;


    private Vector2 _movementInput;
    private Vector2 _smoothedMoveInput;
    private Vector2 _smoothMoveVelocity;

    [Header("Dash Variables")]
    [SerializeField] bool canDash = true;
    [SerializeField] bool isDashing;
    [SerializeField] float dashPower;
    [SerializeField] float dashTime;
    [SerializeField] float dashCooldown;
    [SerializeField] private TrailRenderer dashTrail;
    private float waitTime;




    private void Awake()
    {
       _rb = GetComponent<Rigidbody2D>();
       dashTrail = GetComponent<TrailRenderer>();
       canDash = true;
        _animator = GetComponent<Animator>();
    }

    private void Update()
    {
       
    }

    private void SetAnimation()
    {
        bool isMoving = _movementInput != Vector2.zero;
        _animator.SetBool("IsMoving", isMoving);
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




    private void OnMove(InputValue inputValue)
    {
      _movementInput =  inputValue.Get<Vector2>();

    }

    private void OnFire(InputValue inputValue)
    {
      
        Debug.Log("Pressed Dash Button");
        
    }

    

}
