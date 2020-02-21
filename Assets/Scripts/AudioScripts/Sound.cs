using System;
using UnityEngine;

[Serializable]
public class Sound
{
    [HideInInspector]
    public AudioSource source;
    public AudioClip clip;
    [Range(0.0f, 1.0f)]
    public float volume;
    [Range(0.0f, 3.0f)]
    public float pitch;
    public string name;
    public bool loop;
    public bool playOnAwake;
}