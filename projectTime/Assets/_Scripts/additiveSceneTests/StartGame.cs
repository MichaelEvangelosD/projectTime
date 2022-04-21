using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGame : MonoBehaviour
{
    private void OnGUI()
    {
        if (GUI.Button(new Rect(10, 10, 100, 30), "START"))
        {
            //AdditiveLoader.S.LoadNextScene(GameScenes.)
        }
    }
}
