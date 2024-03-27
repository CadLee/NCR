using UnityEngine;
using UnityEngine.Networking;
using System.Collections;

public class PlayAudioStream : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(GetAudioClip());
    }

    IEnumerator GetAudioClip()
    {
        using (UnityWebRequest www = UnityWebRequestMultimedia.GetAudioClip("https://incompetech.com/music/royalty-free/mp3-royaltyfree/Fluffing%20a%20Duck.mp3", AudioType.MPEG))
        {
            yield return www.SendWebRequest();

            if (www.result == UnityWebRequest.Result.ConnectionError)
            {
                Debug.Log(www.error);
            }
            else
            {
                AudioClip music = DownloadHandlerAudioClip.GetContent(www);
                AudioSource PlayMusic;
                PlayMusic = GetComponent<AudioSource>();
                PlayMusic.clip = music;
                PlayMusic.loop = true;
                PlayMusic.Play();
            }
        }
    }
}