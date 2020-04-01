using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class AudioManager : MonoBehaviour
{
	//Singleton
	public static AudioManager current;

	//soundtracks	BGM
	public List<AudioClip> AudioClips = new List<AudioClip>();

	//Audio source
	public AudioSource MyAudioSource;

	//Some high pass filter
	public AudioHighPassFilter HighPass;

	private int _songIndex;

	public float LerpSpeed;

    #region Properties
    public bool MuteBGM
	{
		get
		{
			return _muteBGM;
		}
		set
		{
			_muteBGM = value;
		}
	}
	#endregion

	private void Awake()
	{
		current = this;
	}
	private void Update()
	{
		if (!MyAudioSource.isPlaying)
			ListConverter(_songIndex++);
	}
	//Changes the cutoff frequency and highpass resonance
	public void ChangeHighPass (float cutFreq, float resonance)
	{
		HighPass.cutoffFrequency = Mathf.Lerp(HighPass.cutoffFrequency, cutFreq, LerpSpeed);

		HighPass.highpassResonanceQ = Mathf.Lerp(HighPass.highpassResonanceQ, resonance, LerpSpeed);
	}
	//Chooses song from song list and continues after ending last song
	public void ListConverter(int number)
	{
		if (number > AudioClips.Count)
			_songIndex = 0;

		MyAudioSource.clip = AudioClips[_songIndex];

		MyAudioSource.Play();
	}
}