using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager current;

    private bool _blockMovement;
    private bool _blockDpad;

    #region Properties
    //Value for blocking the input of the dpad
    public bool BlockDpad
    {
        get
        {
            return _blockDpad;
        }
        set
        {
            _blockDpad = value;
        }
    }
    //Value for blocking the player movement
    public bool BlockMovement
    {
        get
        {
            return _blockMovement;
        }
        set
        {
            _blockMovement = value;
        }
    }
    #endregion
    private void Awake ()
    {
        current = this;
        UIManager.current.HideExitingGame = true;
    }
}
