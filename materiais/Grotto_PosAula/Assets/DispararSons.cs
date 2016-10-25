using UnityEngine;
using UnityEngine.Audio;
using System.Collections;

public class DispararSons : MonoBehaviour {
	public AudioMixer mixer;
	public AudioClip somPulo;
	public AudioClip somPegada;
	public AudioClip somChamado;
	AudioSource _audio;

	void Start () {
		_audio = GetComponent<AudioSource> ();

	}

	void ComecarPulo () {
		print ("comecou a pular");
		_audio.PlayOneShot (somPulo);
		mixer.SetFloat("FreqAmbiencia", Random.Range(0.5f, 1.5f));
	}

	void TocarPegada () {
		_audio.PlayOneShot (somPegada);
	}

	void TocarChamado () {
		_audio.PlayOneShot (somChamado);
	}
}
