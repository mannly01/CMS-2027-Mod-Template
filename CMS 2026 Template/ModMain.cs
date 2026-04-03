using MelonLoader;
using System.IO;
using UnityEngine;

/*
    Add References to the following files:
        Folder: Steam\steamapps\common\Car Mechanic Simulator 2026\MelonLoader\Il2CppAssemblies
            Assembly-CSharp.dll
            Il2CppFusion.Runtime.dll
            Il2Cppmscorlib.dll
            Il2CppSystem.dll
            UnityEngine.CoreModule.dll
            UnityEngine.dll
            UnityEngine.InputLegacyModule.dll
            UnityEngine.UI.dll
        Folder: Steam\steamapps\common\Car Mechanic Simulator 2026\MelonLoader\net6
            Il2CppInterop.Runtime.dll
            MelonLoader.dll
*/

namespace $safeprojectname$
{
    /// <summary>
    /// Information for MelonLoader.
    /// </summary>
    public static class BuildInfo
    {
        public const string Name = "$safeprojectname$";
        public const string Description = "";
        public const string Author = "REPLACE_ME";
        public const string Company = null;
        public const string Version = "1.0.0";
        public const string DownloadLink = null;
        public const string MelonGameCompany = "";
        public const string MelonGameName = "";
    }

    /// <summary>
    /// Create a "$safeprojectname$.cfg" file in the Mods folder.
    /// </summary>
    public class $safeprojectname$ConfigFile
    {
        /// <summary>
        /// Settings Category
        /// </summary>
        private const string SettingsCatName = "$safeprojectname$Settings";
        private readonly MelonPreferences_Category _settings;

        public $safeprojectname$ConfigFile()
        {
#if DEBUG
            MelonLogger.Msg("ConfigFile.Init: Called");
#endif
            _settings = MelonPreferences.CreateCategory(SettingsCatName);
            _settings.SetFilePath("Mods/$safeprojectname$.cfg");

            if (!File.Exists($"{Directory.GetCurrentDirectory()}\\Mods\\$safeprojectname$.cfg"))
            {
                _settings.SaveToFile();
            }
        }
    }

    public class $safeprojectname$ : MelonMod
    {
        /// <summary>
        /// Reference to Settings file.
        /// </summary>
        private $safeprojectname$ConfigFile _configFile;

        /// <summary>
        /// Global reference to the current scene.
        /// </summary>
        private string _currentScene = string.Empty;

        public override void OnInitializeMelon()
        {
            // Tell the user that we're loading the Settings.
            MelonLogger.Msg("Loading Settings...");
            _configFile = new $safeprojectname$ConfigFile();
        }

        public override void OnSceneWasInitialized(int buildIndex, string sceneName)
        {
            if (buildIndex == -1)
            {
                return;
            }
            // Save a reference to the current scene.
            _currentScene = sceneName.ToLower();
            if (_currentScene.Equals("christmas") ||
                _currentScene.Equals("easter") ||
                _currentScene.Equals("halloween"))
            {
                MelonLogger.Msg($"{sceneName} custom scene is active");
                _currentScene = "garage";
            }
#if DEBUG
            if (_currentScene.Equals("garage") ||
                _currentScene.Equals("barn") ||
                _currentScene.Equals("junkyard"))
            {
                MelonLogger.Msg($"SceneName: {_currentScene}");
            }
#endif
        }

        public override void OnUpdate()
        {
#if DEBUG
            if (Input.GetKeyDown(KeyCode.J))
            {
                // This is a test key that should not be shipped with a release.
            }
#endif
        }
    }
}
