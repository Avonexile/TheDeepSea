﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //TESTS
    public float SwimmingSpeedModifier; //TODO: Place this in the modifier list
    public float LandSpeedModifier; //TODO: Place this in the modifier list
    //TESTS

    private Transform MyCam;
    private Rigidbody MyRB;

    private float _movementSpeed;
    private float _baseLandSpeed = 5f;
    private float _baseWaterSpeed = 1.5f;
    private bool _isSwimming;

    //TODO: Make properties for these
    public float _jumpHeight = 5f;
    public bool IsJumping;
    //TODO: Make propertiess for these

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
                _movementSpeed *= SwimmingSpeedModifier;

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
                MyRB.useGravity = false;
                MovementSpeed = BaseWaterSpeed;
            }
            else
            {
                MyRB.useGravity = true;
                MovementSpeed = BaseLandSpeed;
            }
        }
    }
    #endregion

    private void Awake ()
    {
        MyCam = GameObject.FindObjectOfType<Camera>().transform;
        MyRB = GetComponent<Rigidbody>();

        IsSwimming = false;
    }
    private void FixedUpdate()
    {
        MovementInput();
    }
    private void MovementInput ()
    {
        Vector3 direction =  new Vector3();

        if (IsSwimming)
        {
            if (Input.GetKey(KeyCode.W))
                direction += MyCam.forward;

            if (Input.GetKey(KeyCode.S))
                direction -= MyCam.forward;

            if (Input.GetKey(KeyCode.A))
                direction -= MyCam.right;

            if (Input.GetKey(KeyCode.D))
                direction += MyCam.right;

            if (Input.GetKey(KeyCode.LeftControl))
                direction += Vector3.down;

            if (Input.GetKey(KeyCode.Space))
                direction += Vector3.up;
        }
        else
        {
            MyCam.forward = new Vector3(MyCam.forward.x, 0, MyCam.forward.z);

            if (Input.GetKey(KeyCode.W))
                direction += MyCam.forward;

            if (Input.GetKey(KeyCode.S))
                direction -= MyCam.forward;

            if (Input.GetKey(KeyCode.A))
                direction -= MyCam.right;

            if (Input.GetKey(KeyCode.D))
                direction += MyCam.right;
            
            if (Input.GetKeyDown(KeyCode.Space))
                Jump();
        }
        transform.position = transform.position + direction * Time.deltaTime * MovementSpeed;
    }
    private void Jump ()
    {
        if (IsJumping)
            return;

        IsJumping = true;

        MyRB.AddForce(new Vector3(0, MyRB.velocity.y + _jumpHeight, 0), ForceMode.Impulse);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Ground" && IsJumping)
            IsJumping = false;
    }
}
