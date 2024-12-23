using NUnit.Framework;
using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace StatSystem.Tests
{
    public abstract class BaseTests
    {
        [OneTimeSetUp]
        protected void OneTimeSetup()
        {
            EditorSceneManager.LoadSceneInPlayMode(
                path: "Assets/StatSystem/Tests/Scenes/Test.unity",
                parameters: new LoadSceneParameters(LoadSceneMode.Single));
        }

        protected Stat GetStatFor(string stat)
        {
            StatController statController = Object.FindObjectOfType<StatController>();
            return statController.stats[stat];
        }
    }
}
