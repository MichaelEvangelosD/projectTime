using UnityEngine;

public class NextLevel : MonoBehaviour
{
    [SerializeField] GameScenes nextScene;

    private void OnGUI()
    {
        if (GUI.Button(new Rect(10, 30, 100, 30), "Load next Level"))
        {
            LoadNextLevel(nextScene);
        }
    }

    void LoadNextLevel(GameScenes scene)
    {
        AdditiveLoader.S.LoadNextScene(scene, true);
    }
}
