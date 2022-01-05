using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioRecieverScript : MonoBehaviour
{
    public AudioSource source;
    public AudioClip[] sounds;
    public void wood()
    {
        source.PlayOneShot(sounds[0]);
    }
    public void stab()
    {
          source.PlayOneShot(sounds[0]);
    }
    public void death(){
          source.PlayOneShot(sounds[1]);
    }
    public void die(){
          source.PlayOneShot(sounds[2]);
    }
}
