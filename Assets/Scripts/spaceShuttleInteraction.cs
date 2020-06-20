using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class spaceShuttleInteraction : MonoBehaviour
{
    public bool winState = false;
    public GameObject particles;

    public void Update()
    {
        if (winState == false)
        {
            this.enabled = false;
        }

        if (winState == true)
        {
            this.enabled = true;
            particles.SetActive(true);
        }
    }

    public void OnClick()
    {
        SceneManager.LoadScene(0);
    }

}
