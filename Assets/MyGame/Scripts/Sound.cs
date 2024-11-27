using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

//klasse sound muss serialisierbar sein
[System.Serializable]

public class Sound
{
    // Start is called before the first frame update
    public string name;
    // Der Audio-Clip 
    public AudioClip clip;
    // Die Lautstärke
    [Range(0f, 1f)]
    public float volume;
    // Der Pic
    [Range(0.1f, 3f)]
    public float pitch;

    [HideInInspector] public AudioSource audioSource;
}
