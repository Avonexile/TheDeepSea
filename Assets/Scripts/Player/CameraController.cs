using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform FocusPoint;

    private Camera MyCam;

    private float Zoom = 5f;
    private float MinZoom = 25f;
    private float MaxZoom = 50f;
    private float ZoomTime = 5f; //TODO: Make property?

    private float MinRotateClamp = -85f;
    private float MaxRotateClamp = 85f;

    private float MouseX;
    private float MouseY;

    private float RotationSpeed = 2f; //TODO: Make property


    private float SmoothVelocity = 25f;
    private float SmoothDamp = 2f;
    private float DistanceSmooth;


    private float ZoomSpeed = 10f;//TODO: Make property

    void Awake ()
    {
        MyCam = GetComponent<Camera>();
    }
    private void FixedUpdate()
    {
        //CheckForObjectInView();
        CameraZoom();
    }
    private void LateUpdate()
    {
        CameraRotation();
        CameraSmoothZoom();
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
        MouseX += Input.GetAxis("Mouse X") * RotationSpeed;
        MouseY -= Input.GetAxis("Mouse Y") * RotationSpeed;

        MouseY = Mathf.Clamp(MouseY, MinRotateClamp, MaxRotateClamp);

        Vector3 dir = new Vector3(0, 0, -Zoom);
        Quaternion rot = Quaternion.Euler(MouseY, MouseX, 0);
        transform.position = FocusPoint.position + rot * dir;

        transform.LookAt(FocusPoint.transform);
    }
    //Controls the zoom level
    void CameraZoom ()
    {
        Zoom -= Input.GetAxis("Mouse ScrollWheel") * ZoomSpeed;
        DistanceSmooth = Mathf.SmoothDamp(DistanceSmooth, Zoom, ref SmoothVelocity, SmoothDamp);
        Zoom = Mathf.Clamp(Zoom, MinZoom, MaxZoom);
    }
    //Controls the "smoothing" of the zoom level
    void CameraSmoothZoom()
    {
        MyCam.fieldOfView = Mathf.Lerp(MyCam.fieldOfView, Zoom, Time.deltaTime * ZoomTime);
    }
}