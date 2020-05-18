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

    public bool firstTime;

    public float time;

    private void Awake()
    {
        current = this;
        firstTime = true;
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
        time = 0;

        while (FindingTreasure)
        {
            if(firstTime)
            {
                //TODO explain the vibrating
                UIManager.current.ChangeHUDMode(UIManager.current.VibrationNotification, true);
                firstTime = false;
            }
            //When far away, seconds between soft quick vibration

            time += Time.deltaTime;
          
            Keyframe[] keyframes = controllerPulseCurve.keys;
            keyframes[0].value = 1.3f - distance / 10;
            controllerPulseCurve.keys = keyframes;

            GamePad.SetVibration(0, 0, controllerPulseCurve.Evaluate(time));

            yield return null;
        }
        StopCoroutine(Finding());
    }
}
