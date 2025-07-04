using System.Collections.Generic;
using System.Linq;
using FluentAssertions;
using NUnit.Framework;
using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Tests.EditorMode
{
    public class ValidationTests
    {
        [TestCaseSource(nameof(AllScenesPaths))]
        public void AllGameObjectsShouldNotHaveMissingScripts(string scenePath)
        {
            Scene scene = EditorSceneManager.OpenScene(scenePath, OpenSceneMode.Additive);

            var gameObjectsWithMissingScripts =
                GetAllGameObjects(scene)
                    .Where(HasMissingScript)
                    .GroupBy(gameObject => gameObject.name)
                    .Select(grouping => $"{grouping.Key} ({grouping.Count()})")
                    .ToList();

            EditorSceneManager.CloseScene(scene, true);

            gameObjectsWithMissingScripts.Should().BeEmpty();
        }

        private static IEnumerable<string> AllScenesPaths() =>
            AssetDatabase
                .FindAssets("t:Scene", new[] { "Assets" })
                .Select(AssetDatabase.GUIDToAssetPath);

        static bool HasMissingScript(GameObject gameObject) =>
            GameObjectUtility.GetMonoBehavioursWithMissingScriptCount(gameObject) > 0;

        private static IEnumerable<GameObject> GetAllGameObjects(Scene scene)
        {
            var gameObjects = new Queue<GameObject>(scene.GetRootGameObjects());

            while (gameObjects.Count > 0)
            {
                GameObject gameObject = gameObjects.Dequeue();

                yield return gameObject;

                foreach (Transform child in gameObject.transform)
                {
                    gameObjects.Enqueue(child.gameObject);
                }
            }
        }
    }
}