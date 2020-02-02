using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SparkleSounds : MonoBehaviour
{
    public AudioSource sourceOfTheAudio;

    public AudioClip Sparkle;

    private void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
    }

    // Start is called before the first frame update
    void Start()
    {
        sourceOfTheAudio = GetComponent<AudioSource>();
    }

    public void PlaySparkles()
    {
        sourceOfTheAudio.PlayOneShot(Sparkle, 0.5f);
    }
}
