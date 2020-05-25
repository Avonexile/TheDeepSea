using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectFader : MonoBehaviour
{
    public MeshRenderer CurrentMeshRenderer;
    public MeshRenderer LastMeshRenderer;

    public Transform Player;
    public Transform Camera;

    private Vector3 direction;
    private float distance;

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;

        direction = Player.position - Camera.position;

        distance = Vector3.Distance(Player.position, Camera.position);

        Debug.DrawRay(Camera.position, direction, Color.red);

        // Does the ray intersect any objects excluding the player layer
        if (Physics.Raycast(Camera.position, direction, out hit, distance))
        {
            if (hit.transform.tag != "Player" && PlayerMovementController.current.IsSwimming)
            {
                Debug.Log("obstruction");
                if (CurrentMeshRenderer == null)
                {
                    if (hit.transform.GetComponent<MeshRenderer>() == null)
                    {
                        CurrentMeshRenderer = hit.transform.GetComponentInParent<MeshRenderer>();
                        CurrentMeshRenderer.enabled = false;
                    }
                    else
                    {
                        CurrentMeshRenderer = hit.transform.GetComponent<MeshRenderer>();
                        CurrentMeshRenderer.enabled = false;
                    }
                }
                if (hit.transform.GetComponentInParent<MeshRenderer>() != CurrentMeshRenderer)
                {
                    LastMeshRenderer = CurrentMeshRenderer;
                    LastMeshRenderer.enabled = true;
                }
            }
            else
            {
                Debug.Log("no obstruction");
                if (CurrentMeshRenderer == null)
                    return;
                else
                {
                    LastMeshRenderer = CurrentMeshRenderer;

                    CurrentMeshRenderer = null;

                    LastMeshRenderer.enabled = true;
                }
            }
        }
    }
}
