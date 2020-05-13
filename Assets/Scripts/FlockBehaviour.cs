using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlockBehaviour : MonoBehaviour
{
    public SplineWalker spline;

    public AnimationCurve escapeSpeedCurve;

    private float duration;

    private bool _speeding;

    #region Properties
    public bool Speeding
    {
        get
        {
            return _speeding;
        }
        set
        {
            _speeding = value;
        }
    }
    #endregion 

    private void Start()
    {
        spline = GetComponent<SplineWalker>();
        duration = spline.duration;
        GetComponent<Collider>().isTrigger = true;

        //Changes the animation curve based on duration value
        Keyframe[] keyframes = escapeSpeedCurve.keys;

        keyframes[0].value = duration;
        keyframes[1].value = duration * 0.8f;
        keyframes[2].value = duration + 1;

        escapeSpeedCurve.keys = keyframes;
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            _speeding = true;

            //Reset after some time
            StartCoroutine(Escape());
        }
    }
    //The escape reaction to the player
    private IEnumerator Escape ()
    {
        float time = 0;

        while(_speeding)
        {
            time += Time.deltaTime;

            spline.duration = escapeSpeedCurve.Evaluate(time);

            if (spline.duration > duration)
                _speeding = false;

            yield return null;
        }
        StopCoroutine(Escape());
    }
}
