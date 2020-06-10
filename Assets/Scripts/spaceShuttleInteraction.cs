using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class spaceShuttleInteraction : MonoBehaviour
{
    public Button yes;
    public Button no;

    public GameObject panel;

    // Start is called before the first frame update
    public void OnClickSHuttle()
    {
        panel.SetActive(true);
    }
    
    public void OnClickYes()
    {
        SceneManager.LoadScene(0);
    }

    public void OnClickNo()
    {
        panel.SetActive(false);
    }
}
