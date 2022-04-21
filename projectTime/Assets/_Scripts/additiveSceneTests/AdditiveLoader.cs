using System;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public enum GameScenes
{
    ManagersScene = 0,
    UI_Scene = 1,
    MainMenu = 2,
    PlayerScene = 3,
    PlayerHub = 4,
    Level1 = 5,
    Level2 = 6,
    Level3 = 7,
    Level4 = 8,
    Level5 = 9,
    BossRoom = 10,
}

public class AdditiveLoader : MonoBehaviour
{
    public static AdditiveLoader S;

    [SerializeField] GameScenes sceneToLoad;

    private void Awake()
    {
        S = this;
    }

    private void Start()
    {
        LoadBaseScenes();
    }

    void LoadBaseScenes()
    {
        SceneManager.LoadScene((int)GameScenes.UI_Scene, LoadSceneMode.Additive);
        SceneManager.LoadScene((int)GameScenes.MainMenu, LoadSceneMode.Additive);
    }

    private void OnGUI()
    {
        if (GUI.Button(new Rect(10, 10, 100, 30), "Load next scene"))
        {
            //UnloadCurrentScene(SceneManager.GetSceneByBuildIndex((int)sceneToLoad - 1));
            LoadNextScene(sceneToLoad);
        }
    }

    public void LoadNextScene(GameScenes scene)
    {
        SceneManager.LoadScene((int)scene, LoadSceneMode.Additive);
    }

    private void OnDestroy()
    {
        S = null;
    }
}
