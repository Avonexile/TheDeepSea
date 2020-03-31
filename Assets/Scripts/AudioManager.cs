using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class AudioManager : MonoBehaviour
{
	public static AudioManager current;

	//soundtracks	BGM
	public List<AudioClip> AudioClips = new List<AudioClip>();

	//audio source
	public AudioSource MyAudioSource;

	public AudioHighPassFilter HighPass;

	//volume
	private bool _muteBGM;

	private int SongIndex;

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
			ListConverter(SongIndex++);
	}
	public void ChangeHighPass (float cutFreq, float resonance)
	{
		HighPass.cutoffFrequency = Mathf.Lerp(HighPass.cutoffFrequency, cutFreq, LerpSpeed);

		HighPass.highpassResonanceQ = Mathf.Lerp(HighPass.highpassResonanceQ, resonance, LerpSpeed);
	}
	public void ListConverter(int number)
	{
		if (number > AudioClips.Count)
			SongIndex = 0;

		MyAudioSource.clip = AudioClips[SongIndex];
		PlayMusic(AudioClips[SongIndex]);
	}
	public void PlayMusic(AudioClip music)
	{
		MyAudioSource.Play();
	}
	public void Mute(bool active)
	{
		MuteBGM = !active;
		MyAudioSource.mute = MuteBGM;
	}
}