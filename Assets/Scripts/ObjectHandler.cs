using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using Boo.Lang;

public class ObjectHandler : MonoBehaviour
{
    public GameObject WinPanel;

    public GameObject[] ObjectsToFind;
    public GameObject[] ObjectsUI;


    public List<GameObject> allObjects = new List<GameObject>();

    public int objectCount = 0;
    public int MaxObjects = 5;

    public bool panel = false;
    

    public void Update()
    {
        if (objectCount == MaxObjects)
        {
            Debug.Log("YOU WIN!");
            WinPanel.SetActive(true);
            panel = true;
        }

        for (int i = 0; i < ObjectsToFind.Length; i++)
        {
            if (ObjectsToFind[i] == false)
            {
                Destroy(ObjectsUI[i]);
            }
        }

        if (panel == true)
        {
            StartCoroutine(waitTime());
        }

    }

    IEnumerator waitTime()
    {
        yield return new WaitForSeconds(5);
        Destroy(WinPanel);
    }
 
}