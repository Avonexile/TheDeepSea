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

    public Animator HUDAnimator;
    public Animator ExitGameAnimator;

    public Animator BagIcon;
    public Animator CameraIcon;

    public bool IsPressed;

    private bool _cursorState;

    private bool _hideExitingGame;

    public float DPadCooldown;

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
           ChangeHUDMode(HUDAnimator, value);
        }
    }
    public bool HideExitingGame
    {
        get
        {
            return _hideExitingGame;
        }
        set
        {
            _hideExitingGame = value;

            GameManager.current.BlockMovement = !value;

            //If true, disable HUD, else enable
            ChangeHUDMode(ExitGameAnimator, value);
        }
    }
    #endregion
    private void Awake ()
    {
        current = this;

        HideExitingGame = true;
        CursorState = false;//Test
    }
    // Update is called once per frame
    void Update()
    {
        float dpadX = Input.GetAxis("DPad X");
        float dpadY = Input.GetAxis("DPad Y");

        if (Input.GetButtonDown("Start")) //Start button to exit game
        {
            HideExitingGame = !HideExitingGame;
        }
        if (dpadY < 0 && !IsPressed)
        {
            IsPressed = true;
            StartCoroutine(Cooldown());

            DownArrow.Play("ArrowClick");
            CameraIcon.Play("SelectIcon");
            PhotoMode = !PhotoMode;
        }
        else if(dpadY > 0)
        {
            UpArrow.Play("ArrowClick");
            //BagIcon.Play("SelectIcon");
        }
        else if(dpadX < 0)
        {
            LeftArrow.Play("ArrowClick");
        }
        else if(dpadX > 0)
        {
            RightArrow.Play("ArrowClick");
        }
        //Check for esc button
    }
    public void ResumeGame ()
    {
        //Unfreeze time/movement
    }
    public void QuitGame()
    {
        Application.Quit();
    }
    #region HUD Related
    public void ChangeHUDMode (Animator anim, bool value)
    {
        if (HUDAnimator.GetBool("On") && anim != HUDAnimator)
            PhotoMode = !PhotoMode;

        anim.SetBool("On", value);
    }
    IEnumerator Cooldown ()
    {
        while (IsPressed)
        {
            yield return new WaitForSeconds(DPadCooldown);

            IsPressed = false;
        }
        StopCoroutine(Cooldown());
    }
    #endregion
}
