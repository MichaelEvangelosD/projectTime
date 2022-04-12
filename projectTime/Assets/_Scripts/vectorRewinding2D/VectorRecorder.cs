using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VectorRecorder : MonoBehaviour
{
    public VectorHandler vectorHandler;
    [SerializeField, Range(0, 1)] float recordInterval;

    private void Start()
    {
        vectorHandler.ResetVectorList();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            vectorHandler.ResetVectorList();

            StartCoroutine(StartVectorRecording(PassCordsList));
        }
    }

    IEnumerator StartVectorRecording(Action<List<Vector2>> coroutineCallback)
    {
        Vector2 tempVector = Vector2.zero;
        List<Vector2> tempCordList = new List<Vector2>();
        tempCordList.Capacity = vectorHandler.GetListCapacity();

        Debug.Log("Started recording");

        for (int i = 0; i < tempCordList.Capacity; i++)
        {
            tempVector.Set(gameObject.transform.position.x, gameObject.transform.position.y);
            tempCordList.Add(tempVector);

            yield return new WaitForSeconds(recordInterval);
        }

        Debug.Log("Recording completed");

        coroutineCallback(tempCordList);
    }

    void PassCordsList(List<Vector2> list)
    {
        vectorHandler.SetCordList(list);
    }
}
