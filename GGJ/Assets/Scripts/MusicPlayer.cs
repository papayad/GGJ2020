using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class MusicPlayer : MonoBehaviour
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

    // Update is called once per frame
    void Update()
    {
        sourceOfTheAudio.loop = true;
        sourceOfTheAudio.Play();
    }
}
