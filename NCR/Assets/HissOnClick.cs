using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class HissOnClick : MonoBehaviour
{

    public AudioClip Hiss;
    AudioSource hissOnClick;
    void Start()
    {
        hissOnClick = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            hissOnClick.PlayOneShot(Hiss, 0.6F);
        }
    }
}