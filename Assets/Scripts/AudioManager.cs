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

	public AudioChorusFilter ChorusFilter;

	private int _songIndex;

	public float LerpSpeed;

    #region Properties
	public int SongIndex
	{
		get
		{
			return _songIndex;
		}
		set
		{
			_songIndex = value;
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
	public void ChangeChorusFilter(float drymix, float wetmix1, float wetmix2, float wetmix3, float delay, float rate, float depth)
	{
		ChorusFilter.dryMix = Mathf.Lerp(ChorusFilter.dryMix, drymix, LerpSpeed);
		ChorusFilter.wetMix1 = Mathf.Lerp(ChorusFilter.wetMix1, wetmix1, LerpSpeed); ;
		ChorusFilter.wetMix2 = Mathf.Lerp(ChorusFilter.wetMix2, wetmix2, LerpSpeed); ;
		ChorusFilter.wetMix3 = Mathf.Lerp(ChorusFilter.wetMix3, wetmix3, LerpSpeed); ;
		ChorusFilter.delay = Mathf.Lerp(ChorusFilter.delay, delay, LerpSpeed); ;
		ChorusFilter.rate = Mathf.Lerp(ChorusFilter.rate, rate, LerpSpeed); ;
		ChorusFilter.depth = Mathf.Lerp(ChorusFilter.depth, depth, LerpSpeed); ;
	}
	//Chooses song from song list and continues after ending last song
	public void ListConverter(int number)
	{
		if (number > AudioClips.Count)
			SongIndex = 0;

		MyAudioSource.clip = AudioClips[SongIndex];

		MyAudioSource.Play();
	}
}