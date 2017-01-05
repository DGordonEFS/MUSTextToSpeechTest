using UnityEngine;
using System;
using System.IO;

namespace Crosstales.RTVoice.Util
{
    /// <summary>Collected constants of very general utility for the asset.</summary>
    public static class Constants
    {

        #region Constant variables

        /// <summary>Name of the asset.</summary>
        public const string ASSET_NAME = "RTVoice PRO"; //PRO
        //public const string ASSET_NAME = "RTVoice"; //DLL

        /// <summary>Version of the asset.</summary>
        public const string ASSET_VERSION = "2.5.2";

        /// <summary>Build number of the asset.</summary>
        public const int ASSET_BUILD = 252;

        /// <summary>Create date of the asset (YYYY, MM, DD).</summary>
        public static readonly DateTime ASSET_CREATED = new DateTime(2015, 4, 29);

        /// <summary>Change date of the asset (YYYY, MM, DD).</summary>
        public static readonly DateTime ASSET_CHANGED = new DateTime(2016, 10, 26);

        /// <summary>Author of the asset.</summary>
        public const string ASSET_AUTHOR = "crosstales LLC";

        /// <summary>URL of the asset author.</summary>
        public const string ASSET_AUTHOR_URL = "http://www.crosstales.com";

        /// <summary>URL of the asset.</summary>
        public const string ASSET_URL = "https://www.assetstore.unity3d.com/#!/content/41068"; //PRO
        //public const string ASSET_URL = "https://www.assetstore.unity3d.com/#!/content/48394"; //DLL

        /// <summary>URL for update-checks of the asset</summary>
        public const string ASSET_UPDATE_CHECK_URL = "http://www.crosstales.com/media/assets/rtvoice_versions.txt";

        /// <summary>Contact to the owner of the asset.</summary>
        public const string ASSET_CONTACT = "rtvoice@crosstales.com";

        /// <summary>UID of the asset.</summary>
        public static readonly Guid ASSET_UID = new Guid("181f4dab-261f-4746-85f8-849c2866d353"); //PRO
        //public static readonly Guid ASSET_UID = new Guid("1ffe8fd4-4e17-497b-9df7-7cd9200d0941"); //DLL

        /// <summary>URL of the asset manual.</summary>
        public const string ASSET_MANUAL_URL = "http://www.crosstales.com/en/assets/rtvoice/RTVoice-doc.pdf";

        /// <summary>URL of the asset API.</summary>
        public const string ASSET_API_URL = "http://goo.gl/6w4Fy0"; // http://www.crosstales.com/en/assets/rtvoice/api/
        //public const string ASSET_API_URL = "http://www.crosstales.com/en/assets/rtvoice/api/";

        /// <summary>URL of the asset forum.</summary>
        public const string ASSET_FORUM_URL = "http://goo.gl/Z6MZMl"; //ok 23.07.2016
        //public const string ASSET_FORUM_URL = "http://forum.unity3d.com/threads/rt-voice-run-time-text-to-speech-solution.340046/";

        /// <summary>URL of the asset in crosstales.</summary>
        public const string ASSET_CT_URL = "http://www.crosstales.com/en/assets/rtvoice/";

        /// <summary>Name of the RT-Voice scene object.</summary>
        public const string RTVOICE_SCENE_OBJECT_NAME = "RTVoice";

        // Keys for the configuration of the asset
        private const string KEY_PREFIX = "RTVOICE_CFG_";
        public const string KEY_ASSET_PATH = KEY_PREFIX + "ASSET_PATH";
        public const string KEY_DEBUG = KEY_PREFIX + "DEBUG";
        public const string KEY_UPDATE_CHECK = KEY_PREFIX + "UPDATE_CHECK";
        public const string KEY_UPDATE_OPEN_UAS = KEY_PREFIX + "UPDATE_OPEN_UAS";
        //public const string KEY_DONT_DESTROY_ON_LOAD = KEY_PREFIX + "DONT_DESTROY_ON_LOAD";
        public const string KEY_PREFAB_AUTOLOAD = KEY_PREFIX + "PREFAB_AUTOLOAD";
        public const string KEY_AUDIOFILE_PATH = KEY_PREFIX + "AUDIOFILE_PATH";
        public const string KEY_AUDIOFILE_AUTOMATIC_DELETE = KEY_PREFIX + "AUDIOFILE_AUTOMATIC_DELETE";
        public const string KEY_ENFORCE_32BIT_WINDOWS = KEY_PREFIX + "ENFORCE_32BIT_WINDOWS";
        //public const string KEY_TTS_MACOS = KEY_PREFIX + "TTS_MACOS";
        public const string KEY_UPDATE_DATE = KEY_PREFIX + "UPDATE_DATE";

        // Default values
        public const string DEFAULT_ASSET_PATH = "/crosstales/RTVoice/";
        public const bool DEFAULT_DEBUG = false;
        public const bool DEFAULT_UPDATE_CHECK = true;
        public const bool DEFAULT_UPDATE_OPEN_UAS = false;
        public const bool DEFAULT_DONT_DESTROY_ON_LOAD = true;
        public const bool DEFAULT_PREFAB_AUTOLOAD = false;
        public static readonly string DEFAULT_AUDIOFILE_PATH = Path.GetTempPath();
        public const bool DEFAULT_AUDIOFILE_AUTOMATIC_DELETE = true;
        public const bool DEFAULT_ENFORCE_32BIT_WINDOWS = false;
        public const string DEFAULT_TTS_WINDOWS_BUILD = @"/RTVoiceTTSWrapper.exe"; //TODO PlayerPrefs?
        public const string DEFAULT_TTS_MACOS = "say";
        public const int DEFAULT_TTS_KILL_TIME = 5000; //TODO PlayerPrefs?

        #endregion

        #region Changable variables
        /// <summary>Path to the asset inside the Unity project.</summary>
        public static string ASSET_PATH = DEFAULT_ASSET_PATH;

        /// <summary>Enable or disable debug logging for the asset.</summary>
        public static bool DEBUG = DEFAULT_DEBUG;

        /// <summaryEnable or disable update-checks for the asset.</summary>
        public static bool UPDATE_CHECK = DEFAULT_UPDATE_CHECK;

        /// <summaryOpen the UAS-site when an update is found.</summary>
        public static bool UPDATE_OPEN_UAS = DEFAULT_UPDATE_OPEN_UAS;

        /// <summary>Don't destroy RTVoice during scene switches.</summary>
        public static bool DONT_DESTROY_ON_LOAD = DEFAULT_DONT_DESTROY_ON_LOAD;

        /// <summary>Automatically load and add the prefabs to the scene.</summary>
        public static bool PREFAB_AUTOLOAD = DEFAULT_PREFAB_AUTOLOAD;

        /// <summary>Path to the generated audio files.</summary>
        public static string AUDIOFILE_PATH = DEFAULT_AUDIOFILE_PATH;

        /// <summary>Automatically delete the generated audio files.</summary>
        public static bool AUDIOFILE_AUTOMATIC_DELETE = DEFAULT_AUDIOFILE_AUTOMATIC_DELETE;

        /// <summary>Enforce 32bit versions of voices under Windows.</summary>
        public static bool ENFORCE_32BIT_WINDOWS = DEFAULT_ENFORCE_32BIT_WINDOWS;


        // Technical settings
        /// <summary>Location of the TTS-wrapper under Windows (stand-alone).</summary>
        public static string TTS_WINDOWS_BUILD = DEFAULT_TTS_WINDOWS_BUILD;

        /// <summary>Location of the TTS-system under MacOS.</summary>
        public static string TTS_MACOS = DEFAULT_TTS_MACOS;

        /// <summary>Kill processes after 5000 milliseconds.</summary>
        public static int TTS_KILL_TIME = DEFAULT_TTS_KILL_TIME;

        /// <summary>Sub-path to the prefabs.</summary>
        public static string PREFAB_SUBPATH = "Prefabs/";

        /// <summary>Sub-path to the TTS-wrapper under Windows (Editor).</summary>
        public static string TTS_WINDOWS_SUBPATH = "Plugins/Windows/RTVoiceTTSWrapper.exe";

        /// <summary>Sub-path to the TTS-wrapper (32bit) under Windows (Editor).</summary>
        public static string TTS_WINDOWS_x86_SUBPATH = "Plugins/Windows/RTVoiceTTSWrapper_x86.exe";

        // Text fragments for the asset
        public static string TEXT_TOSTRING_START = " {";
        public static string TEXT_TOSTRING_END = "}";
        public static string TEXT_TOSTRING_DELIMITER = "', ";
        public static string TEXT_TOSTRING_DELIMITER_END = "'";

        #endregion

        #region Properties

        /// <summary>Path of the prefabs.</summary>
        public static string PREFAB_PATH
        {
            get
            {
                return ASSET_PATH + PREFAB_SUBPATH;
            }
        }

        /// <summary>Location of the TTS-wrapper under Windows (Editor).</summary>
        public static string TTS_WINDOWS_EDITOR
        {
            get
            {
                return ASSET_PATH + TTS_WINDOWS_SUBPATH;
            }
        }

        /// <summary>Location of the TTS-wrapper (32bit) under Windows (Editor).</summary>
        public static string TTS_WINDOWS_EDITOR_x86
        {
            get
            {
                return ASSET_PATH + TTS_WINDOWS_x86_SUBPATH;
            }
        }

        #endregion

        #region Public static methods

        /// <summary>Resets all changable variables to their default value.</summary>
        public static void Reset()
        {
            ASSET_PATH = DEFAULT_ASSET_PATH;
            DEBUG = DEFAULT_DEBUG;
            UPDATE_CHECK = DEFAULT_UPDATE_CHECK;
            UPDATE_OPEN_UAS = DEFAULT_UPDATE_OPEN_UAS;
            DONT_DESTROY_ON_LOAD = DEFAULT_DONT_DESTROY_ON_LOAD;
            PREFAB_AUTOLOAD = DEFAULT_PREFAB_AUTOLOAD;
            AUDIOFILE_PATH = DEFAULT_AUDIOFILE_PATH;
            AUDIOFILE_AUTOMATIC_DELETE = DEFAULT_AUDIOFILE_AUTOMATIC_DELETE;
            ENFORCE_32BIT_WINDOWS = DEFAULT_ENFORCE_32BIT_WINDOWS;
            TTS_WINDOWS_BUILD = DEFAULT_TTS_WINDOWS_BUILD;
            TTS_MACOS = DEFAULT_TTS_MACOS;
            TTS_KILL_TIME = DEFAULT_TTS_KILL_TIME;
        }

        /// <summary>Loads the all changable variables.</summary>
        public static void Load()
        {
            if (CTPlayerPrefs.HasKey(KEY_DEBUG))
            {
                DEBUG = CTPlayerPrefs.GetBool(KEY_DEBUG);
            }

            if (CTPlayerPrefs.HasKey(KEY_UPDATE_CHECK))
            {
                UPDATE_CHECK = CTPlayerPrefs.GetBool(KEY_UPDATE_CHECK);
            }

            if (CTPlayerPrefs.HasKey(KEY_UPDATE_OPEN_UAS))
            {
                UPDATE_OPEN_UAS = CTPlayerPrefs.GetBool(KEY_UPDATE_OPEN_UAS);
            }

            //if (CTPlayerPrefs.HasKey(KEY_DONT_DESTROY_ON_LOAD))
            //{
            //    DONT_DESTROY_ON_LOAD = CTPlayerPrefs.GetBool(KEY_DONT_DESTROY_ON_LOAD);
            //}

            if (CTPlayerPrefs.HasKey(KEY_ASSET_PATH))
            {
                ASSET_PATH = CTPlayerPrefs.GetString(KEY_ASSET_PATH);
            }

            if (CTPlayerPrefs.HasKey(KEY_PREFAB_AUTOLOAD))
            {
                PREFAB_AUTOLOAD = CTPlayerPrefs.GetBool(KEY_PREFAB_AUTOLOAD);
            }

            if (CTPlayerPrefs.HasKey(KEY_AUDIOFILE_PATH))
            {
                AUDIOFILE_PATH = CTPlayerPrefs.GetString(KEY_AUDIOFILE_PATH);
            }

            if (CTPlayerPrefs.HasKey(KEY_AUDIOFILE_AUTOMATIC_DELETE))
            {
                AUDIOFILE_AUTOMATIC_DELETE = CTPlayerPrefs.GetBool(KEY_AUDIOFILE_AUTOMATIC_DELETE);
            }

            if (CTPlayerPrefs.HasKey(KEY_ENFORCE_32BIT_WINDOWS))
            {
                ENFORCE_32BIT_WINDOWS = CTPlayerPrefs.GetBool(KEY_ENFORCE_32BIT_WINDOWS);
            }

            //if (CTPlayerPrefs.HasKey(KEY_TTS_MACOS))
            //{
            //    TTS_MACOS = CTPlayerPrefs.GetString(KEY_TTS_MACOS);
            //}
        }

        /// <summary>Saves the all changable variables.</summary>
        public static void Save()
        {
            CTPlayerPrefs.SetString(KEY_ASSET_PATH, ASSET_PATH);
            CTPlayerPrefs.SetBool(KEY_DEBUG, DEBUG);
            CTPlayerPrefs.SetBool(KEY_UPDATE_CHECK, UPDATE_CHECK);
            CTPlayerPrefs.SetBool(KEY_UPDATE_OPEN_UAS, UPDATE_OPEN_UAS);
            //CTPlayerPrefs.SetBool(KEY_DONT_DESTROY_ON_LOAD, DONT_DESTROY_ON_LOAD);
            CTPlayerPrefs.SetBool(KEY_PREFAB_AUTOLOAD, PREFAB_AUTOLOAD);
            CTPlayerPrefs.SetString(KEY_AUDIOFILE_PATH, AUDIOFILE_PATH);
            CTPlayerPrefs.SetBool(KEY_AUDIOFILE_AUTOMATIC_DELETE, AUDIOFILE_AUTOMATIC_DELETE);
            CTPlayerPrefs.SetBool(KEY_ENFORCE_32BIT_WINDOWS, ENFORCE_32BIT_WINDOWS);
            //CTPlayerPrefs.SetString(KEY_TTS_MACOS, TTS_MACOS);

            CTPlayerPrefs.Save();
        }

        #endregion
    }
}
// Copyright 2015-2016 www.crosstales.com