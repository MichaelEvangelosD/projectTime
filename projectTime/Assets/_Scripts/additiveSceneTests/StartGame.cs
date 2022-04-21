using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGame : MonoBehaviour
{
    private void OnGUI()
    {
        if (GUI.Button(new Rect(150, 150, 100, 30), "START"))
        {
            LoadGame();
        }
    }

    //We can add save loading in here!
    void LoadGame()
    {
        AdditiveLoader.S.LoadNextScene(GameScenes.PlayerHub, true);
    }
}
