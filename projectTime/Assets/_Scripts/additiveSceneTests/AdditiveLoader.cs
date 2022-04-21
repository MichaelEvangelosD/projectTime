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
        LoadDesiredScene(gameStartScene);
    }

    public void LoadDesiredScene(GameScenes scene, bool unloadCurrent = false)
    {
        if (unloadCurrent)
        {
            //WE CAN MAKE THIS AN ENUMERATION TO MAKE A LOADING SCREEN
            UnloadSceneAsync(lastLoadedScene);
        }

        if (scene.Equals(GameScenes.PlayerHub))
        {
            _LoadPlayerScene();
            _LoadUIScene();
        }

        lastLoadedScene = scene;
        SceneManager.LoadScene((int)scene, LoadSceneMode.Additive);
    }

    public void UnloadSceneAsync(GameScenes scene)
    {
        SceneManager.UnloadSceneAsync((int)scene);
    }

    //THESE COULD BE MOVED TO THE GAME MANAGER EVENT SYSTEM
    //AND GET CALLED AS LoadDesiredScene(...) from there.
    void _LoadPlayerScene()
    {
        LoadDesiredScene(GameScenes.PlayerScene);
    }

    void _LoadUIScene()
    {
        LoadDesiredScene(GameScenes.UI_Scene);
    }

    private void OnDestroy()
    {
        S = null;
    }
}
