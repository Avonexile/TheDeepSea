﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform FocusPoint;

    private Camera MyCam;

    private float MinRotateClamp = -85f;
    private float MaxRotateClamp = 85f;

    private float MouseX;
    private float MouseY;

    private float _rotationSpeed = 4f;
    private float _zoom = 20f;

    #region Properties
    public float RotationSpeed
    {
        get
        {
            return _rotationSpeed;
        }
        set
        {
            _rotationSpeed = value;
        }
    }
    public float Zoom
    {
        get
        {
            return _zoom;
        }
        set
        {
            _zoom = value;
        }
    }
    #endregion
    void Awake ()
    {
        MyCam = GetComponent<Camera>();
    }
    private void LateUpdate()
    {
        CameraRotation();
    }
    //Controls camera rotation and focus point
    void CameraRotation()
    {
        MouseX += Input.GetAxis("Mouse X Cont") * _rotationSpeed;
        MouseY -= Input.GetAxis("Mouse Y Cont") * _rotationSpeed;

        MouseY = Mathf.Clamp(MouseY, MinRotateClamp, MaxRotateClamp);

        Vector3 dir = new Vector3(0, 0, -Zoom);
        Quaternion rot = Quaternion.Euler(MouseY, MouseX, 0);

        transform.position = FocusPoint.position + rot * dir;

        transform.LookAt(FocusPoint.transform);
    }
}