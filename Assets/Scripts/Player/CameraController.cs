﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform FocusPoint;

    private Camera MyCam;

    public float Zoom = 25f; //TODO: Make property

    private float MinRotateClamp = -85f;
    private float MaxRotateClamp = 85f;

    private float MouseX;
    private float MouseY;

    public float RotationSpeed = 4f; //TODO: Make property


    void Awake ()
    {
        MyCam = GetComponent<Camera>();
    }
    private void LateUpdate()
    {
        CameraRotation();
    }
    //void CheckForObjectInView ()
    //{
    //    RaycastHit hit;

    //    if(Physics.Raycast(transform.position, FocusPoint.position, out hit))
    //    {
    //        if(hit.transform.tag != "Player")
    //        {
    //            MeshRenderer MR = hit.transform.GetComponent<MeshRenderer>();
    //            MR.material.color = new Color(MR.material.color.r, MR.material.color.g, MR.material.color.b, 0.1f);
    //            Debug.Log("Found one");
    //        }
    //    }
    //}
    //Controls camera rotation and focus point
    void CameraRotation()
    {
        MouseX += Input.GetAxis("Mouse X Cont") * RotationSpeed;
        MouseY -= Input.GetAxis("Mouse Y Cont") * RotationSpeed;

        MouseY = Mathf.Clamp(MouseY, MinRotateClamp, MaxRotateClamp);

        Vector3 dir = new Vector3(0, 0, -Zoom);
        Quaternion rot = Quaternion.Euler(MouseY, MouseX, 0);

        transform.position = FocusPoint.position + rot * dir;

        transform.LookAt(FocusPoint.transform);
    }
}