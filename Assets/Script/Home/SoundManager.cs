using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoSingleton<SoundManager>
{
    [Header("Input")]
    public AudioClip wingSound;
    [SerializeField] public AudioClip swooshingSound;
    [SerializeField] public AudioClip pointSound;
    [SerializeField] public AudioClip dieSound;
    [SerializeField] public AudioClip hitSound;

    public void PlaySound(AudioClip clip)
    {
        AudioSource audio = GetComponent<AudioSource>();

        audio.PlayOneShot(clip);
    }

}
