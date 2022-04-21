using UnityEngine;

public class NextLevel : MonoBehaviour
{
    public float yGUI_Value = 10f;

    [SerializeField] GameScenes nextScene;

    private void OnGUI()
    {
        if (GUI.Button(new Rect(10, yGUI_Value, 100, 30), "Load next Level"))
        {
            LoadNextLevel(nextScene);
        }
    }

    void LoadNextLevel(GameScenes scene)
    {
        if (scene.Equals(GameScenes.MainMenu))
        {
            AdditiveLoader.S.UnloadSceneAsync(GameScenes.PlayerScene);
            AdditiveLoader.S.UnloadSceneAsync(GameScenes.UI_Scene);
        }

        AdditiveLoader.S.LoadDesiredScene(scene, true);
    }
}
