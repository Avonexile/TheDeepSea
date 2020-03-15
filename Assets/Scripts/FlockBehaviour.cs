using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlockBehaviour : MonoBehaviour
{
    public SplineWalker spline;

    private void Start()
    {
        spline = GetComponent<SplineWalker>();
        GetComponent<Collider>().isTrigger = true;
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            spline.duration = spline.duration * 0.5f;

            //Reset after some time

            //Slightly accelerate and deaccelerate over time
        }
    }
}
