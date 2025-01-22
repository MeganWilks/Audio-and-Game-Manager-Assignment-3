using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{

    [SerializeField] AudioSource audioSource;

    public AudioClip music;

    private void Start()
    {
        audioSource.Play();
    }
}

