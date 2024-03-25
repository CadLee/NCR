using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class PressMToMeowScript : MonoBehaviour {

    public AudioSource Meow;
    void Start()
    {
        Meow = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.M))
        {
            if (!Meow.isPlaying)
            {
                Meow.Play();
            }

            if (Input.GetKeyUp(KeyCode.M))
            {
                Meow.Stop();
            }
        }
    }
}
