using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ObjectHandler : MonoBehaviour
{
    public GameObject WinPanel;

    public GameObject[] ObjectsToFind;
    public GameObject[] ObjectsUI;

    public int objectCount = 0;
    public int MaxObjects = 5;

    public void Update()
    {
        if (objectCount == MaxObjects)
        {
            Debug.Log("YOU WIN!");
            WinPanel.SetActive(true);
        }

        for (int i = 0; i < ObjectsToFind.Length; i++)
        {
            if (ObjectsToFind[i] == false)
            {
                ObjectsUI[i].GetComponent<Image>().color = Color.black;
            }
        }
    }

 
}