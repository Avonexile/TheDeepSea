using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public static UIManager current;

    [Header("Wheel Options")]
    public Animator UpArrow;
    public Animator DownArrow;
    public Animator LeftArrow;
    public Animator RightArrow;

    private bool _photoMode;

    public GameObject HUDObject;

    public Animator BagIcon;
    public Animator CameraIcon;

    public GameObject DepthMeter;

    public bool PhotoMode
    {
        get
        {
            return _photoMode;
        }
        set
        {
            _photoMode = value;

            //If true, disable HUD, else enable
            HUDObject.SetActive(!value);
        }
    }
    private void Awake ()
    {
        current = this;
    }
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.DownArrow))
        {
            DownArrow.Play("ArrowClick");
            CameraIcon.Play("SelectIcon");
            PhotoMode = !PhotoMode;
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            UpArrow.Play("ArrowClick");
            BagIcon.Play("SelectIcon");
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            LeftArrow.Play("ArrowClick");
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            RightArrow.Play("ArrowClick");
        }
    }
    public void ShowElement (GameObject item)
    {
        item.SetActive(!item.activeSelf);
    }
    public void ShowDepthMeter (bool show)
    {
        DepthMeter.SetActive(show);
    }
}
