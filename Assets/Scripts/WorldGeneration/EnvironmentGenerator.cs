using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnvironmentGenerator : MonoBehaviour
{
    public float ChunkSize;

    public int MaxChunkLoaded;
    private int LoadedChunks = 0;

    public List<Chunk> Chunks = new List<Chunk>();
    public List<Chunk> CurrentLoadedChunks = new List<Chunk>();

    public Chunk CurrentChunk;

    public float ChunkLoadingTime;

    public Transform playerObject;

    private void Awake()
    {
        //Start coroutine
        StartCoroutine(LoadChunks());
    }
    private IEnumerator LoadChunks ()
    {
        while(LoadedChunks < MaxChunkLoaded)
        {
            if(Chunks.Count == 0)
            {
                //Create chunks
                CurrentChunk = new Chunk(0, new Vector3(-ChunkSize / 2, 0, ChunkSize / 2), new Vector3(ChunkSize / 2, 0, -ChunkSize / 2));
                CurrentLoadedChunks.Add(CurrentChunk);
                Chunks.Add(CurrentChunk);



                //Spawn Props in chunk
            }

            //Load Chunk

            yield return new WaitForSeconds(ChunkLoadingTime);
        }
        StopCoroutine(LoadChunks());
    }
    public void OnDrawGizmos ()
    {
        foreach (var item in Chunks)
        {
            Gizmos.DrawCube(item.Center, new Vector3(ChunkSize , 0, ChunkSize));

            Gizmos.DrawSphere(item.Center, 5f);
            Gizmos.DrawLine(item.TopLeftCoords, item.BottomRightCoords);

        }
    }
}
