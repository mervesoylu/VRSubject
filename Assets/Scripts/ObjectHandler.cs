using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class ObjectHandler : MonoBehaviour
{
    public GameObject WinPanel;
    public Transform Player;

    public List<GameObject> ObjectsToFind;
    public List<GameObject> ObjectsUI;


    public int objectCount = 12;
    public int MaxObjects = 0;

    public bool panel = false;
    

    public void Update()
    {
        if (ObjectsToFind.Count == 0)
        {
            Debug.Log("YOU WIN!");
            WinPanel.SetActive(true);
            panel = true;
        }

        for (int i = 0; i < ObjectsToFind.Count; i++)
        {
            if (ObjectsToFind[i].transform.position == Player.position)
            {
                Destroy(ObjectsUI[i]);
                ObjectsUI.Remove(ObjectsUI[i]);
                ObjectsToFind.Remove(ObjectsToFind[i]);
            }
        }

        if (panel == true)
        {
            StartCoroutine(waitTime());
        }

        Debug.Log(ObjectsToFind.Count);

    }

    IEnumerator waitTime()
    {
        yield return new WaitForSeconds(5);
        Destroy(WinPanel);
    }
 
}