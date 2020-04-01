﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager current;

    private bool _blockMovement;

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
    private bool _blockDpad;

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
    private void Awake ()
    {
        current = this;
        UIManager.current.HideExitingGame = true;
    }
}
