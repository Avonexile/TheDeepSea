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

    private bool _cursorState;

    #region Properties
    public bool CursorState
    {
        get
        {
            return _cursorState;
        }
        set
        {
            _cursorState = value;

            if(value)
            {
                Cursor.visible = false;
                Cursor.lockState = CursorLockMode.Locked;
            }
            else
            {
                Cursor.visible = true;
                Cursor.lockState = CursorLockMode.None;
            }
        }
    }
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
    #endregion
    private void Awake ()
    {
        current = this;

        CursorState = false;//Test
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
        //Check for esc button
    }
}
