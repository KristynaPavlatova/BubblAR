using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleFromAudioClip : MonoBehaviour
{
    //https://www.youtube.com/watch?v=dzD0qP8viLw&ab_channel=ValemTutorials
    //7:28
    public AudioSource source;
    public Vector3 minScale;
    public Vector3 maxScale;
    public AudioLoundnessDetection detector;

    void Update()
    {
        float loudness = detector.GetLoudnessFromAudioClip(source.timeSamples, source.clip);
        transform.localScale = Vector3.Lerp(minScale, maxScale, loudness);
    }
}
