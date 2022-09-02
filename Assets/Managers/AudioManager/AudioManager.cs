using UnityEngine.Audio;
using UnityEngine;
using System;

public class AudioManager : MonoBehaviour
{
    public Sound[] sounds;
    public static AudioManager audiomanager;

    
    void Awake()
    {
        //check that we dont destroy the object when changing scene and check
        //that there is only one audio manager per scene
        DontDestroyOnLoad(gameObject);

        if(audiomanager == null)
        {
            audiomanager = this;
        }
        else
        {
            Destroy(gameObject);
        }

        //create an audio source component for every sound in our array and 
        //give the correspondin values to every audio source
        foreach(Sound s in sounds)
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;
            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
        } 
    }

    //finds the sound that we want to play if it exists and then it plays it
    public void Play(string name)
    {
        Sound s = Array.Find(sounds, sound => sound.name == name);
        
        if(s == null)
        {
            Debug.LogWarning("The sound " + name + "does not exist");
            return;
            
        }
        s.source.Play();


    }
}
