using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class ObjectHandler : MonoBehaviour
{
    public GameObject WinPanel;
    public Transform Player;
    public GameObject PostIt;

    public List<GameObject> ObjectsToFind;
    public List<GameObject> ObjectsUI;

    public int objectCount = 12;
    public int MaxObjects = 0;

    public bool panel = false;
    private bool panelTrue = false;
    private bool panelFalse = false;
    

    public void Update()
    {
        if (ObjectsToFind.Count == 0)
        {
            Debug.Log("YOU WIN!");
            panelTrue = true;
        }

        for (int i = 0; i < ObjectsToFind.Count; i++)
        {
            if (ObjectsToFind[i].transform.position == Player.position)
            {
                Destroy(ObjectsUI[i]);
                ObjectsUI.Remove(ObjectsUI[i]);
                ObjectsToFind.Remove(ObjectsToFind[i]);

                PostIt.GetComponent<Image>().color = Color.green;
                Invoke("ChangeColor", 1);
            }
        }

        if (panel == true)
        {
            StartCoroutine(waitTime());
        }

        if (panelTrue == true)
        {
            WinPanel.SetActive(true);
            panel = true;
        }

        if (panelFalse == true)
        {
            panelTrue = false;
            WinPanel.SetActive(false);
        }

    }

    public void ChangeColor()
    {
        PostIt.GetComponent<Image>().color = new Color(255, 255, 255);
    }

    IEnumerator waitTime()
    {
        yield return new WaitForSeconds(5);
        panelFalse = true;
        WinPanel.SetActive(false);
    }
 
}