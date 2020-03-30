using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class UIManager : MonoBehaviour
{
    public static UIManager current;

    public EventSystem EventSystemClass;
    
    public GameObject[] FirstSelectedUI;

    [Header("Wheel Options")]
    public Animator UpArrow;
    public Animator DownArrow;
    public Animator LeftArrow;
    public Animator RightArrow;

    private bool _photoMode;

    public Animator HUDAnimator;
    public Animator ExitGameAnimator;
    public Animator ClueAnimator;
    public Animator TitleScreen;

    public Animator BagIcon;
    public Animator CameraIcon;

    public bool IsPressed;

    private bool _cursorState;

    private bool _hideExitingGame;

    private bool _readingClue;

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

            EventSystemClass.firstSelectedGameObject = FirstSelectedUI[0];

            //Blocks the player movement
            GameManager.current.BlockMovement = !value;

            //If true, disable HUD, else enable
            ChangeHUDMode(ExitGameAnimator, value);
        }
    }
    public bool ReadingClue
    {
        get
        {
            return _readingClue;
        }
        set
        {
            _readingClue = value;

            EventSystemClass.firstSelectedGameObject = FirstSelectedUI[1];

            //Blocks the player movement
            GameManager.current.BlockMovement = value;

            //If true, disable HUD, else enable
            ChangeHUDMode(ClueAnimator, !value);

            
        }
    }
    #endregion
    private void Awake ()
    {
        current = this;

        //HideExitingGame = true;

        ClueAnimator.SetBool("On", true);
        CursorState = false;//Test
    }
    private void Start()
    {
        TitleScreen.SetBool("Hide", true);
    }

    // Update is called once per frame
    void Update()
    {
        //Dpad button inputs
        float dpadX = Input.GetAxis("DPad X");
        float dpadY = Input.GetAxis("DPad Y");

        //Start button to exit game
        if (Input.GetButtonDown("Start")) 
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
        }
        else if(dpadX < 0)
        {
            LeftArrow.Play("ArrowClick");
        }
        else if(dpadX > 0)
        {
            RightArrow.Play("ArrowClick");
        }
    }
    public void ResumeGame ()
    {
        Debug.Log("Resume game");
        //Unfreeze time/movement
        if (!HideExitingGame)
            HideExitingGame = true;

        if (ReadingClue)
            ReadingClue = false;
    }
    //Quitting the game, stop editor if playing in editor
    public void QuitGame()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
        Application.Quit();
    }
    #region HUD Related
    //Change the visibility of HUD Elements
    public void ChangeHUDMode (Animator anim, bool value)
    {
        if (HUDAnimator.GetBool("On") && anim != HUDAnimator)
            PhotoMode = !PhotoMode;

        anim.SetBool("On", value);

        if (anim == ExitGameAnimator)
            anim.GetComponent<CanvasGroup>().interactable = !value;
    }
    //Fix for multi input values from dpad
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
