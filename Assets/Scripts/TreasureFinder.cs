using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreasureFinder : MonoBehaviour
{
    private GameObject treasure;

    private float distance;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Treasure")
        {
            //Vibrate
        }
    }
    private void OnTriggerStay(Collider other)
    {
        if(other.tag == "Treasure")
        {
            if(treasure == null)
                treasure = other.gameObject;

            //Check distance between player and treasure
            distance = Vector3.Distance(transform.position, other.transform.position);
            
            //Vibrate depending on distance
        }
    }
}
