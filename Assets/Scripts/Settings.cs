using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Settings : MonoBehaviour
{
    public static Settings current;

    private bool _xAxis;
    private bool _yAxis;

    private float _volume;

    #region Properties
    public bool XAxis
    {
        get
        {
            return _xAxis;
        }
        set
        {
            _xAxis = value;
            //Set the camera inverted
            CameraController.current.InvertX = value;
        }
    }
    public bool YAxis
    {
        get
        {
            return _yAxis;
        }
        set
        {
            _yAxis = value;

            CameraController.current.InvertY = value;
        }
    }
    public float Volume
    {
        get
        {
            return _volume;
        }
        set
        {
            _volume = value;
            AudioManager.current.MyAudioSource.volume = value;
            UIManager.current.ChangeVolumeText(Mathf.RoundToInt(value * 100f));
        }
    }
    #endregion
    private void Start()
    {
        current = this;
        ChangeVolume(.5f);
        XAxis = true;
        YAxis = true;
    }
    public void ChangeVolume (float newVolume)
    {
        Volume = newVolume;
    }
}
