using System;
using UnityEngine;

public class EntityAudio : MonoBehaviour
{
	[SerializeField] private Sound[] _sounds = default;
	[SerializeField] private SoundGroup[] _soundGroups = default;


	void Awake()
	{
		SetSounds();
		SetSoundGroups();
	}

	private void SetSounds()
	{
		foreach (Sound sound in _sounds)
		{
			sound.source = gameObject.AddComponent<AudioSource>();
			sound.source.clip = sound.clip;

			sound.source.volume = sound.volume;
			sound.source.pitch = sound.pitch;
			sound.source.loop = sound.loop;
			sound.source.playOnAwake = sound.playOnAwake;
			if (sound.source.playOnAwake)
			{
				sound.source.Play();
			}
		}
	}

	private void SetSoundGroups()
	{
		foreach (SoundGroup soundGroup in _soundGroups)
		{
			foreach (Sound sound in soundGroup.sounds)
			{
				sound.source = gameObject.AddComponent<AudioSource>();
				sound.source.clip = sound.clip;

				sound.source.volume = sound.volume;
				sound.source.pitch = sound.pitch;
				sound.source.loop = sound.loop;
				sound.source.playOnAwake = sound.playOnAwake;
				if (sound.source.playOnAwake)
				{
					sound.source.Play();
				}
			}
		}
	}

	public void Play(string name)
	{
		Sound sound = Array.Find(_sounds, s => s.name == name);
		sound.source.Play();
	}

	public void Stop(string name)
	{
		Sound sound = Array.Find(_sounds, s => s.name == name);
		sound.source.Stop();
	}

	public bool IsPlaying(string name)
	{
		Sound sound = Array.Find(_sounds, s => s.name == name);
		return sound.source.isPlaying;
	}

	public void PlayRandomFromSoundGroup(string name)
	{
		SoundGroup soundGroup = Array.Find(_soundGroups, sg => sg.name == name);
		Sound randomSound = soundGroup.sounds[UnityEngine.Random.Range(0, soundGroup.sounds.Length)];
		randomSound.source.Play();
	}
}