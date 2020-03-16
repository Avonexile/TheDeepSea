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
    private void OnTriggerExit(Collider other)
    {
        if(other.tag == "Player")
        {
            //_speeding = false;
        }
    }

    private IEnumerator Escape ()
    {
        float time = 0;

        while(_speeding)
        {
            Debug.Log("Run");
            time += Time.deltaTime;

            spline.duration = escapeSpeedCurve.Evaluate(time);

            if (spline.duration > 20)
                _speeding = false;

            yield return null;
        }
        StopCoroutine(Escape());
    }
}
