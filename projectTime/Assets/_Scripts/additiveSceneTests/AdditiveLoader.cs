using UnityEngine;
using UnityEngine.SceneManagement;

public enum GameScenes
{
    GameEntryScene = 0,
    MainMenu = 1,
    UI_Scene = 2,
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

    [SerializeField] GameScenes gameStartScene;

    GameScenes lastLoadedScene;

    private void Awake()
    {
        S = this;
    }

    private void Start()
    {
        LoadNextScene(gameStartScene);
    }

    public void LoadNextScene(GameScenes scene, bool unloadCurrent = false)
    {
        if (unloadCurrent)
        {
            SceneManager.UnloadSceneAsync((int)lastLoadedScene);

            //WE CAN MAKE THIS AN ENUMERATION TO MAKE A LOADING SCREEN
        }

        lastLoadedScene = scene;
        SceneManager.LoadScene((int)scene, LoadSceneMode.Additive);
    }

    private void OnDestroy()
    {
        S = null;
    }
}
