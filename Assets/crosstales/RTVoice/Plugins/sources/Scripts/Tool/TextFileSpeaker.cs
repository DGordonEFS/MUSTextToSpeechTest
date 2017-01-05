using UnityEngine;
using Crosstales.RTVoice.Model;
using Crosstales.RTVoice.Util;
using System;

namespace Crosstales.RTVoice.Tool
{
    /// <summary>Allows to speak text files.</summary>
    //[ExecuteInEditMode]
    [HelpURL("http://www.crosstales.com/en/assets/rtvoice/api/class_crosstales_1_1_r_t_voice_1_1_tool_1_1_text_file_speaker.html")]
    public class TextFileSpeaker : MonoBehaviour
    {
        private static System.Random rnd = new System.Random();

        /// <summary>Text files to speak.</summary>
        [Tooltip("Text files to speak.")]
        public TextAsset[] TextFiles;

        /// <summary>Name of the RT-Voice under Windows (optional).</summary>
        [Tooltip("Name of the RT-Voice under Windows (optional).")]
        public string RTVoiceNameWindows = "Microsoft David Desktop";

        /// <summary>Name of the RT-Voice under macOS (optional).</summary>
        [Tooltip("Name of the RT-Voice under macOS (optional).")]
        public string RTVoiceNameMac = "Alex";

        /// <summary>Name of the RT-Voice under Android.</summary>
        [Tooltip("Name of the RT-Voice under Android.")]
        public string RTVoiceNameAndroid = string.Empty;

        /// <summary>Name of the RT-Voice under iOS.</summary>
        [Tooltip("Name of the RT-Voice under iOS.")]
        public string RTVoiceNameIOS = "Daniel";

        /// <summary>Speak mode (default = Speak).</summary>
        [Tooltip("Speak mode (default = Speak).")]
        public SpeakMode Mode = SpeakMode.Speak;

        [Header("Behaviour Settings")]
        /// <summary>Speak a random text file on start on/off (default: off).</summary>
        [Tooltip("Speak this text on start on/off (default: off).")]
        public bool PlayOnStart = false;

        [Header("Optional Settings")]
        /// <summary>Fallback culture for the text (e.g. 'en', optional).</summary>
        [Tooltip("Fallback culture for the text (e.g. 'en', optional).")]
        public string Culture = "en";

        /// <summary>AudioSource for the output (optional).</summary>
        [Tooltip("AudioSource for the output (optional).")]
        public AudioSource Source;

        /// <summary>Speech rate of the speaker in percent (1 = 100%, default: 1, optional).</summary>
        [Tooltip("Speech rate of the speaker in percent (1 = 100%, default: 1, optional).")]
        [Range(0f, 3f)]
        public float Rate = 1f;

        /// <summary>Speech pitch of the speaker in percent (1 = 100%, default: 1, optional, mobile only).</summary>
        [Tooltip("Speech pitch of the speaker in percent (1 = 100%, default: 1, optional, mobile only).")]
        [Range(0f, 2f)]
        public float Pitch = 1f;

        /// <summary>Volume of the speaker in percent (1 = 100%, default: 1, optional, Windows only).</summary>
        [Tooltip("Volume of the speaker in percent (1 = 100%, default: 1, optional, Windows only).")]
        [Range(0f, 1f)]
        public float Volume = 1f;

        //private string[] texts;

        //private Voice voice;

        private Guid uid;

        #region Properties

        /// <summary>Name of the RT-Voice.</summary>
        public string RTVoiceName
        {
            get
            {
                string result = null;

                if (Helper.isWindowsPlatform)
                {
                    result = RTVoiceNameWindows;
                }
                else if (Helper.isMacOSPlatform)
                {
                    result = RTVoiceNameMac;
                }
                else if (Helper.isAndroidPlatform)
                {
                    result = RTVoiceNameAndroid;
                }
                else
                {
                    result = RTVoiceNameIOS;
                }

                return result;
            }
        }

        #endregion

        //#region MonoBehaviour methods

        public void Start()
        {
            if (PlayOnStart)
            {
                Speak();
            }
        }

        //#endregion

        #region Public methods

        /// <summary>Speaks a random text.</summary>
        public void Speak()
        {
            Silence();
            uid = SpeakText();
        }

        /// <summary>Speaks a text with an optional index.</summary>
        /// <param name="index">Index of the text (default: -1 (random), optional).</param>
        /// <returns>UID of the speaker.</returns>
        public Guid SpeakText(int index = -1)
        {
            string[] texts = new string[TextFiles.Length];

            for (int ii = 0; ii < TextFiles.Length; ii++)
            {
                texts[ii] = TextFiles[ii].text;
            }


            Voice voice = Speaker.VoiceForName(RTVoiceName);

            if (voice == null)
            {
                voice = Speaker.VoiceForCulture(Culture);
            }

            if (texts.Length > 0)
            {
                if (index < 0)
                {
                    if (Helper.isEditorMode)
                    {
#if UNITY_EDITOR
                        Speaker.SpeakNativeInEditor(texts[rnd.Next(texts.Length)], voice, Rate, Volume, Pitch);
#endif
                    }
                    else
                    {
                        if (Mode == SpeakMode.Speak)
                        {
                            uid = Speaker.Speak(texts[rnd.Next(texts.Length)], Source, voice, true, Rate, Volume, "", Pitch);
                        }
                        else
                        {
                            uid = Speaker.SpeakNative(texts[rnd.Next(texts.Length)], voice, Rate, Volume, Pitch);
                        }
                    }

                }
                else
                {
                    if (index < texts.Length)
                    {
                        if (Helper.isEditorMode)
                        {
#if UNITY_EDITOR
                            Speaker.SpeakNativeInEditor(texts[index], voice, Rate, Volume, Pitch);
#endif
                        }
                        else
                        {
                            if (Mode == SpeakMode.Speak)
                            {
                                uid = Speaker.Speak(texts[index], Source, voice, true, Rate, Volume, "", Pitch);
                            }
                            else
                            {
                                uid = Speaker.SpeakNative(texts[index], voice, Rate, Volume, Pitch);
                            }
                        }
                    }
                    else
                    {
                        Debug.LogWarning("Text file index is out of bounds: " + index + " - maximal index is: " + (texts.Length - 1));
                    }
                }
            }
            else
            {
                Debug.LogError("No text files added - speak cancelled!");
            }

            return uid;
        }

        public void Silence()
        {
            if (Helper.isEditorMode)
            {
                Speaker.Silence();
            }
            else
            {
                Speaker.Silence(uid);
            }
        }

        #endregion
    }
}
// Copyright 2016 www.crosstales.com
