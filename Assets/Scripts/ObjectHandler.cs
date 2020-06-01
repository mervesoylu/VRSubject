using UnityEngine;
using System.Collections;

public class ObjectHandler : MonoBehaviour
{
    public GameObject[] ObjectsToFind;
    public GameObject[] ObjectsUI;

    public int objectCount = 0;
    public int MaxObjects = 5;

    public void Update()
    {
        if (objectCount == MaxObjects)
        {
            Debug.Log("YOU WIN!");
        }
    }
}