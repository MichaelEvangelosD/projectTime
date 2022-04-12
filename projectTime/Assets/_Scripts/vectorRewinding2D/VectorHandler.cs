using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "RewindVectorHandling")]
public class VectorHandler : ScriptableObject
{
    [SerializeField, Range(1, 25)] int listCapacity;  

    [SerializeField] List<Vector2> cordsToMoveTo;

    public int GetListCapacity()
    {
        return cordsToMoveTo.Capacity;
    }

    public void SetCordList(List<Vector2> cordsList)
    {
        cordsToMoveTo = cordsList;
    }

    public void ResetVectorList()
    {
        cordsToMoveTo = new List<Vector2>();
        cordsToMoveTo.Capacity = listCapacity;
    }

    public List<Vector2> GetPastCordsList()
    {
        return cordsToMoveTo;
    }
}
