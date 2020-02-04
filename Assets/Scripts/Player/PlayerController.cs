using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Suimono.Core;

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
    private float _baseWaterSpeed = 3f;
    private bool _isSwimming;

    public float Depth;

    //TODO: Make properties for these
    public float _jumpHeight = 5f;
    public bool IsJumping;
    //TODO: Make propertiess for these

    public Vector3 SlowFallValue;
    public float OverTime;

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
                //StartCoroutine(SlowFall(new Vector3(0, -5f, 0)));
                MyRB.velocity = Vector3.zero;
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

    private void Start ()
    {
        MyCam = GameObject.FindObjectOfType<CameraController>().transform;
        MyRB = GetComponent<Rigidbody>();

        IsSwimming = false;
    }
    private void FixedUpdate()
    {
        CheckDepth();
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
    private void CheckDepth ()
    {
        if (transform.position.y < 0f)
            IsSwimming = true;

        else if(transform.position.y > 1f)
            IsSwimming = false;

        Depth = transform.position.y;
    }
    //private IEnumerator SlowFall (Vector3 value)
    //{
    //    MyRB.velocity = value;
       
    //    while(MyRB.velocity.y < 0.1f)
    //    {
    //        Debug.Log(MyRB.velocity);
    //        MyRB.velocity += SlowFallValue;
    //        if (MyRB.velocity.y >= 0f)
    //        {
    //            MyRB.velocity = Vector3.zero;
    //            StopCoroutine(SlowFall(Vector3.zero));
    //        }

    //        yield return new WaitForSeconds(OverTime);
    //    }
    //    StopCoroutine(SlowFall(Vector3.zero));
    //}
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Ground" && IsJumping)
            IsJumping = false;
    }
    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Trigger" && IsSwimming) { }
            //Play climbing animation

        if (collider.gameObject.tag == "Trigger" && !IsSwimming) { }
            //Play animation
    }   
}
