using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Clue : MonoBehaviour
{
    //See if it had been read already
    public bool HasBeenRead;

    public float Speed;

    //The text that can be read
    [TextArea(5, 15)]
    public string Text;

    public void FixedUpdate ()
    {
        transform.Rotate(new Vector3(0, 5 * Time.deltaTime * Speed, 0));
    }
}
