using System;
using UnityEngine;

class AudioManager : MonoBehaviour
{
    [SerializeField] private Sound[] _sounds = default;
    [SerializeField] private SoundGroup[] _soundGroups = default;
    private Sound _previousRandomSound;
    public static AudioManager Instance { get; private set; }


    void Awake()
    {
        CheckInstance();
        SetSounds();
        SetSoundGroups();
    }

    private void CheckInstance()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            Instance = this;
        }
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

    public void PauseEverythingExpect(string name)
    {
        for (int i = 0; i < _sounds.Length; i++)
        {
            if (!_sounds[i].name.Equals(name))
            {
                _sounds[i].source.Pause();
            }
        }
    }

    public void ResumeEverything()
    {
        for (int i = 0; i < _sounds.Length; i++)
        {
            _sounds[i].source.UnPause();
        }
    }

    public bool IsPlaying(string name)
    {
        Sound sound = Array.Find(_sounds, s => s.name == name);
        if (sound.source.isPlaying)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public void PlayRandomFromSoundGroup(string name)
    {
        SoundGroup soundGroup = Array.Find(_soundGroups, sg => sg.name == name);
        Sound randomSound = soundGroup.sounds[UnityEngine.Random.Range(0, soundGroup.sounds.Length)];
        if (randomSound != _previousRandomSound)
        {
            _previousRandomSound = randomSound;
            randomSound.source.Play();
        }
        else
        {
            PlayRandomFromSoundGroup(name);
        }
    }
}
