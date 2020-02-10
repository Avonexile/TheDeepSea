using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
public class Chunk
{
    public int ChunkID;

    public Vector3 TopLeftCoords;
    public Vector3 BottomRightCoords;
    public Vector3 Center;

    private int _maxPropsInChunk = 10;
    private int _minPropsInChunk = 1;

    public List<GameObject> Props = new List<GameObject>();

    #region Properties
    public int MaxPropsInChunk
    {
        get
        {
            return _maxPropsInChunk;
        }
    }
    public int MinPropsInChunk
    {
        get
        {
            return _minPropsInChunk;
        }
    }
    #endregion 

    public Chunk (int index, Vector3 TopleftPos, Vector3 BottomRightPos)
    {
        ChunkID = index;
        TopLeftCoords = TopleftPos;
        BottomRightCoords = BottomRightPos;


        Center = new Vector3(BottomRightCoords.x + TopLeftCoords.x, 0, TopLeftCoords.z + BottomRightCoords.z);
    }
    public Chunk(GameObject Prop)
    {
        Props.Add(Prop);
    }
}
