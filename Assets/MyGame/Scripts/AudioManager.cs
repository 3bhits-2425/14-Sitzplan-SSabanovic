using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    // Instanzvariablen

    [SerializeField] private Sound[] sounds;

    private void Awake()
    {
        foreach (Sound s in sounds)
        {
            // Erzeuge zur Laufzeit ein AudioSource Objekt
            s.audioSource = gameObject.AddComponent<AudioSource>();
            // uebernehme Parameter vom Audio Element in AudioSource 
            s.audioSource.clip = s.clip;
            // Volume
            s.audioSource.volume = s.volume;
            // pitch
            s.audioSource.pitch = s.pitch;
        }
        /*
         for (int i = 0; i < sounds.length; i++){
                Sound s = sounds[i];
         }
        */
    }

    void Play(string soundName)
    {
        foreach (Sound s in sounds)
        {
            if (s.name == soundName)
            {
                s.audioSource.Play();
            }
        }
    }

    void Pause(string soundName)
    {
        foreach (Sound oneSound in sounds)
        {
            if (oneSound.name == soundName)
            {
                oneSound.audioSource.Pause();
            }
        }
    }

    private Sound findSound(string soundName)
    {
        foreach (Sound oneSound in sounds)
        {
            if oneSound.name == soundName)
            {
                return s;
            }
        }
        return null;
    }



    void Start()
    {
    }

    void Update()
    {
    }
}