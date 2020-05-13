using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XInputDotNetPure;

public class TreasureFinder : MonoBehaviour
{
    public static TreasureFinder current;

    private GameObject treasure;

    private float distance;

    private bool FindingTreasure;


    public AnimationCurve controllerPulseCurve;

    private void Awake()
    {
        current = this;
    }
    private void FixedUpdate()
    {
        if (FindingTreasure && treasure != null)
        {
            distance = Vector3.Distance(transform.position, treasure.transform.position);
        }
        else
            GamePad.SetVibration(0, 0, 0);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Treasure")
        {
            FindingTreasure = true;
            if (treasure == null)
                treasure = other.gameObject;

            //Start vibrating
            StartCoroutine(Finding());
        }
    }
    public void TurnOffVibration ()
    {
        FindingTreasure = false;
        treasure = null;
        StopCoroutine(Finding());
    }
    private void OnTriggerExit(Collider other)
    {
        if(other.tag == "Treasure")
        {
            FindingTreasure = false;

            //turn vibration off
            StopCoroutine(Finding());
        }
    }
    private IEnumerator Finding()
    {
        float time = 0;

        while (FindingTreasure)
        {
            time += Time.deltaTime * (1 - (distance / 10)); //* (1 - (distance / 10)

            GamePad.SetVibration(0, 0, controllerPulseCurve.Evaluate(time));

            yield return null;
        }
        StopCoroutine(Finding());
    }
}
