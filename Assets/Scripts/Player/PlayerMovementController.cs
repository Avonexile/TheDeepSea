using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Threading;


public class PlayerMovementController : MonoBehaviour
{
    //TESTS
    public float SwimmingSpeedModifier; //TODO: Place this in the modifier list
    public float LandSpeedModifier; //TODO: Place this in the modifier list
    //TESTS

    private Transform MyCam;
    private Rigidbody MyRB;

    private float _movementSpeed;
    private float _baseLandSpeed = 5f;
    private float _baseWaterSpeed = 3f;
    private bool _isSwimming;

    public float Depth;

    public float _jumpHeight = 5f;
    private bool IsJumping;

    public Animator animatorController;

    private bool IsUnderwater =>
            transform.position.y < 0;

    public float velocityShrinkSpeedUnderwater = .95f;

    public float overTime;

    #region Properties
    public float MovementSpeed
    {
        get
        {
            return _movementSpeed;
        }
        set
        {
            _movementSpeed = value;

            if (IsSwimming)
            {
                _movementSpeed *= SwimmingSpeedModifier;
            }

            else
                _movementSpeed *= LandSpeedModifier;
        }
    }
    public float BaseLandSpeed
    {
        get
        {
            return _baseLandSpeed;
        }
        set
        {
            _baseLandSpeed = value;
        }
    }
    public float BaseWaterSpeed
    {
        get
        {
            return _baseWaterSpeed;
        }
        set
        {
            _baseWaterSpeed = value;
        }
    }
    public bool IsSwimming
    {
        get
        {
            return _isSwimming;
        }
        set
        {
            _isSwimming = value;

            if (value)
            {
                animatorController.SetBool("Swimming", value);
                
                MovementSpeed = BaseWaterSpeed;
            }
            else
            {
                animatorController.SetBool("Swimming", value);
                MovementSpeed = BaseLandSpeed;
            }
        }
    }
    #endregion

    private void Awake()
    {
        MyCam = GameObject.FindObjectOfType<CameraController>().transform;
        MyRB = GetComponent<Rigidbody>();

        IsSwimming = false;

        //TODO: Open thread to keep track of the depth
    }
    private void FixedUpdate()
    {
        Handheld.Vibrate();
        if (GameManager.current.BlockMovement)
            return;

        CheckDepth();
        MovementInput();

        bool underwater = IsUnderwater;
        MyRB.useGravity = !underwater;

        if (!underwater)
            return;

        var velocity = MyRB.velocity;
        velocity *= velocityShrinkSpeedUnderwater;
        MyRB.velocity = velocity;
    }
    private void MovementInput()
    {
        Vector3 direction = new Vector3();

        float vertical = Input.GetAxis("Vertical");
        float horizontal = -Input.GetAxis("Horizontal");

        if (IsUnderwater)
        {
            if (horizontal < 0)
                direction += MyCam.right;
            if (horizontal > 0)
                direction -= MyCam.right;
            if (vertical < 0)
                direction -= MyCam.forward;
            if (vertical > 0)
                direction += MyCam.forward;

            if (Input.GetAxis("SwimUp") > 0)//Swimup/ swimdown
                SwimUp();

            if (Input.GetAxis("SwimDown") > 0)//Swimup/ swimdown
                SwimDown();
        }
        else
        {
            MyCam.forward = new Vector3(MyCam.forward.x, 0, MyCam.forward.z);

            //WORKS BUT UGLY
            if (horizontal < 0)
                direction += MyCam.right;
            if (horizontal > 0)
                direction -= MyCam.right;
            if (vertical < 0)
                direction -= MyCam.forward;
            if (vertical > 0)
                direction += MyCam.forward;

            //IF YOU PRESS THE JUMP BUTTON JUMP
            if (Input.GetButton("Jump"))
                Jump();
        }
        

        transform.position = transform.position + direction * Time.deltaTime * MovementSpeed;

        //Rotate player
        if (direction != Vector3.zero)
        {
            animatorController.SetBool("Walking", true);

            if (transform.forward != direction)
            {
                transform.forward = Vector3.Lerp(transform.forward, direction, Time.deltaTime * overTime);
            }
        }
        else
        {
            animatorController.SetBool("Walking", false);
        }
    }
    private void Jump()
    {
        if (IsJumping)
            return;

        animatorController.SetTrigger("Jump");
        IsJumping = true;

        MyRB.AddForce(new Vector3(0, MyRB.velocity.y + _jumpHeight, 0), ForceMode.Impulse);
    }
    private void SwimDown ()
    {
        Debug.Log("Down");
        if (IsUnderwater)
            MyRB.AddForce(new Vector3(0, -MyRB.velocity.y - _jumpHeight, 0), ForceMode.Acceleration);

        //Swim down rotation

    }
    private void SwimUp ()
    {
        Debug.Log("Up");
        if (IsUnderwater)
            MyRB.AddForce(new Vector3(0, MyRB.velocity.y + _jumpHeight, 0), ForceMode.Acceleration);

        //Swim up rotation
    }
    private void CheckDepth()
    {
        if (transform.position.y < 0f)
            IsSwimming = true;

        else if (transform.position.y > .5f)
            IsSwimming = false;

        Depth = transform.position.y;
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ground" && IsJumping)
        {
            if (Depth > 0)
                animatorController.SetBool("Swimming", false);

            IsJumping = false;
        }
    }
}
