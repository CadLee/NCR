using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class PressMToMeow : MonoBehaviour
{

    public AudioClip Meow;
    AudioSource meowOnMKeyPress;
    void Start()
    {
        meowOnMKeyPress = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.M))
        {
            meowOnMKeyPress.PlayOneShot(Meow, 1.0F);
        }
    }
}