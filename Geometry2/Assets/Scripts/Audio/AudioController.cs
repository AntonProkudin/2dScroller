using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour
{
    public AudioSource audioSrc;

    void Start()
    {
        if (!PlayerPrefs.HasKey("volume"))
            audioSrc.volume = 1;
        else
        audioSrc.volume = PlayerPrefs.GetFloat("volume");
    }
}
