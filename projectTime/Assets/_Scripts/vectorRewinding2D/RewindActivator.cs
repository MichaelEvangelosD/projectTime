using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RewindActivator : MonoBehaviour
{
    [SerializeField] VectorHandler vectorHandler;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            VectorRewinder.S.StartRewind(gameObject, vectorHandler.GetPastCordsList());
        }
    }
}
