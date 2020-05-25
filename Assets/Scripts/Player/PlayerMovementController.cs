﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Threading;


public class PlayerMovementController : MonoBehaviour
{
    public static PlayerMovementController current;
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

    //Speed with which you go down in the water
    public float velocityShrinkSpeedUnderwater = .95f;

    //Character rotation over time
    public float RotateOverTime;

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

                AudioManager.current.ChangeChorusFilter(0,.5f,.5f,.5f,.1f,1f,.25f);

                RotateOverTime = 1.1f;
            }
            else
            {
                animatorController.SetBool("Swimming", value);
                MovementSpeed = BaseLandSpeed;

                AudioManager.current.ChangeChorusFilter(0.5f, 0.5f,0.5f,0.5f,40, .8f, 0.03f);

                RotateOverTime = 10f;
            }
        }
    }
    #endregion

    private void Awake()
    {
        current = this;

        MyCam = GameObject.FindObjectOfType<CameraController>().transform;
        MyRB = GetComponent<Rigidbody>();

        IsSwimming = false;

        //TODO: Open thread to keep track of the depth
    }
    private void FixedUpdate()
    {
        //Check for movement block
        if (GameManager.current.BlockMovement)
            return;

        CheckDepth();
        MovementInput();

        //Check if underwater
        bool underwater = IsUnderwater;
        MyRB.useGravity = !underwater;

        if (!underwater)
            return;

        //Slowly decrease velocity, giving a floating affect in water
        var velocity = MyRB.velocity;
        velocity *= velocityShrinkSpeedUnderwater;
        MyRB.velocity = velocity;
    }
    //Land and water movement and directional swimming
    private void MovementInput()
    {
        Vector3 direction = new Vector3();

        float vertical = Input.GetAxis("Vertical");
        float horizontal = -Input.GetAxis("Horizontal");

        //If the player is underwater
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
            //To make sure character doesn't fly or go down
            MyCam.forward = new Vector3(MyCam.forward.x, 0, MyCam.forward.z);

            //WORKS BUT UGLY. TODO: Check for improvement
            if (horizontal < 0)
                direction += MyCam.right;
            if (horizontal > 0)
                direction -= MyCam.right;
            if (vertical < 0)
                direction -= MyCam.forward;
            if (vertical > 0)
                direction += MyCam.forward;

            //Makes player jump in another function
            if (Input.GetButton("Jump"))
                Jump();
        }
        
        //Movement
        transform.position = transform.position + direction * Time.deltaTime * MovementSpeed;

        //Rotate player
        if (direction != Vector3.zero)
        {
            //Animate player
            animatorController.SetBool("Walking", true);

            //Rotate player according to direction input
            if (transform.forward != direction)
            {
                transform.forward = Vector3.Lerp(transform.forward, direction, Time.deltaTime * RotateOverTime);
            }
        }
        else
        {
            //Stop walking animation
            animatorController.SetBool("Walking", false);
        }
    }
    //Jumping on land
    private void Jump()
    {
        if (IsJumping)
            return;

        animatorController.SetTrigger("Jump");
        IsJumping = true;

        MyRB.AddForce(new Vector3(0, MyRB.velocity.y + _jumpHeight, 0), ForceMode.Impulse);
    }
    //Swimming down 
    private void SwimDown ()
    {
        if (IsUnderwater)
            MyRB.AddForce(new Vector3(0, -MyRB.velocity.y - _jumpHeight, 0), ForceMode.Acceleration);

        //Swim down rotation

    }
    //Swimming up
    private void SwimUp ()
    {
        Debug.Log("Up");
        if (IsUnderwater)
            MyRB.AddForce(new Vector3(0, MyRB.velocity.y + _jumpHeight, 0), ForceMode.Acceleration);

        //Swim up rotation
    }
    //Updates the depth of the character
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
        if (collision.gameObject.tag == "Treasure")
        {
            Clue clue = collision.gameObject.GetComponent<Clue>();

            if (clue.HasBeenRead)
                return;

            TreasureFinder.current.TurnOffVibration();
            collision.gameObject.SetActive(false);
            
            UIManager.current.ChangeClueText(clue.Text);
            clue.HasBeenRead = true;

            UIManager.current.ReadingClue = true;
        }
    }
}
