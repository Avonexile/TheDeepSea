using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using TMPro;

public class UIManager : MonoBehaviour
{
    public static UIManager current;

    public EventSystem EventSystemClass;
    
    public GameObject[] FirstSelectedUI;

    public TextMeshProUGUI ClueText;

    public TextMeshProUGUI VolumeText;

    [Header("Wheel Options")]
    public Animator UpArrow;
    public Animator DownArrow;
    public Animator LeftArrow;
    public Animator RightArrow;

    private bool _photoMode;

    [Header("Fading Animators")]
    public Animator HUDAnimator;
    public Animator ExitGameAnimator;
    public Animator ClueAnimator;
    public Animator TitleScreen;
    public Animator VibrationNotification;
    public Animator OptionsAnimator;

    [Header("Icon Animations")]
    public Animator BagIcon;
    public Animator CameraIcon;

    private bool IsPressed;

    private bool _cursorState;
    private bool _hideExitingGame;
    private bool _options;

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


            ExitGameAnimator.gameObject.GetComponent<CanvasGroup>().interactable = value;

            //Turn interactible exitgamemenu to !value
            EventSystemClass.SetSelectedGameObject(FirstSelectedUI[0]);
            EventSystemClass.firstSelectedGameObject = FirstSelectedUI[0];

            //Blocks the player movement
            GameManager.current.BlockMovement = !value;

            //If true, disable HUD, else enable
            ChangeHUDMode(ExitGameAnimator, value);
        }
    }
    public bool Options
    {
        get
        {
            return _options;
        }
        set
        {
            _options = value;

            OptionsAnimator.gameObject.GetComponent<CanvasGroup>().interactable = value;

            EventSystemClass.SetSelectedGameObject(FirstSelectedUI[2]);
            EventSystemClass.firstSelectedGameObject = FirstSelectedUI[2];

            //Stop animation or play animation
            PlayerMovementController.current.animatorController.enabled = !value;

            //Block input from dpad and start button
            GameManager.current.BlockDpad = value;

            //Blocks the player movement
            GameManager.current.BlockMovement = value;

            //If true, disable HUD, else enable
            ChangeHUDMode(OptionsAnimator, !value);
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

            ClueAnimator.gameObject.GetComponent<CanvasGroup>().interactable = value;

            //Set the UI selection to the close button
            EventSystemClass.SetSelectedGameObject(FirstSelectedUI[1]);
            EventSystemClass.firstSelectedGameObject = FirstSelectedUI[1];

            //Stop animation or play animation
            PlayerMovementController.current.animatorController.enabled = !value;

            //Block input from dpad and start button
            GameManager.current.BlockDpad = value;

            //Blocks the player movement
            GameManager.current.BlockMovement = value;

            //If true, disable HUD, else enable
            ChangeHUDMode(ClueAnimator, !value);
        }
    }
    #endregion
    //Setup for start
    private void Awake ()
    {
        current = this;

        ClueAnimator.SetBool("On", true);

        OptionsAnimator.SetBool("On", true);

        CursorState = true; //Uncomment
    }
    private void Start()
    {
        TitleScreen.SetBool("Hide", true);
    }
    //Checks for input on dpad or start
    void Update()
    {
        //Dpad button inputs
        float dpadX = Input.GetAxis("DPad X");
        float dpadY = Input.GetAxis("DPad Y");

        //Start button to exit game
        if (Input.GetButtonDown("Start") && !Options)
            HideExitingGame = !HideExitingGame;

        //Start button to exit game
        if (Input.GetButtonDown("Options") && HideExitingGame)
            Options = !Options;

        //If dpad and start input isnt blocked
        if (!GameManager.current.BlockDpad)
        {
            if (dpadY < 0 && !IsPressed)
            {
                IsPressed = true;
                StartCoroutine(Cooldown());

                DownArrow.Play("ArrowClick");
                CameraIcon.Play("SelectIcon");
                PhotoMode = !PhotoMode;
            }
            else if (dpadY > 0)
                UpArrow.Play("ArrowClick");

            else if (dpadX < 0)
                LeftArrow.Play("ArrowClick");

            else if (dpadX > 0)
                RightArrow.Play("ArrowClick");
        }
    }
    //Resume game after trying to exit game or reading clues
    public void ResumeGame ()
    {
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
    //Changes the text on the UI based on the text variable in the clue script on the object
    public void ChangeClueText (string text)
    {
        ClueText.text = text;
    }
    public void ChangeVolumeText(float value)
    {
        VolumeText.text = value.ToString() + "%";
    }
    #endregion
}
