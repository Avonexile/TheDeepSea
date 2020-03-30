using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Clue : MonoBehaviour
{
    public bool HasBeenRead;

    [TextArea(5, 15)]
    public string Text;
}
