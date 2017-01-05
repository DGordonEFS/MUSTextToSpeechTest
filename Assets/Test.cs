using UnityEngine;
using System.Collections;
using Crosstales.RTVoice;

public class Test : MonoBehaviour
{
    public AudioSource AudioSource;

    public void Speak()
    {
        Speaker.Speak("Hello world!");
    }

}