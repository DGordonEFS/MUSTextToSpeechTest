using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Crosstales.RTVoice.Model;
using Debug = UnityEngine.Debug;

namespace Crosstales.RTVoice.Provider
{
    public class JavaScriptVoiceProvider : BaseVoiceProvider
    {
        public override string AudioFileExtension
        {
            get { return "none"; }
        }

        public override List<Voice> Voices
        {
            get { return new List<Voice> { new Voice("default", "default", "male", "en", "en")}; }
        }

        public override IEnumerator SpeakNative(WrapperNative wrapper)
        {
            Debug.Log("SpeakNative: " +  wrapper.Text);
            Speak(wrapper.Text);
            yield return null;
        }

        public override IEnumerator Speak(Wrapper wrapper)
        {
            Debug.Log("Speak: " + wrapper.Text);
            Speak(wrapper.Text);
            yield return null;
        }
#if UNITY_EDITOR 
        public override void SpeakNativeInEditor(WrapperNative wrapper)
        {
            throw new NotImplementedException();
        }

        public override void GenerateInEditor(Wrapper wrapper)
        {
            throw new NotImplementedException();
        }
#endif 

#if UNITY_WEBGL
        [DllImport("__Internal")]
        private static extern void Speak(string txt);
#else
        private static void Speak(string text, int speed, int pitch)
        {
            Debug.LogError("JavaScriptVoiceProvider.Speak is only implemented for WebGL targets. UNITY_WEBGL flag not set.");   
        }
#endif
    }

}