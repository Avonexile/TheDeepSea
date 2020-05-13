using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Clue : MonoBehaviour
{
    //See if it had been read already
    public bool HasBeenRead;

    //The text that can be read
    [TextArea(5, 15)]
    public string Text;
}
