using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class spaceShuttleInteraction : MonoBehaviour
{
    public bool winState = false;
    public GameObject particles;
    public GameObject jetSound;

    public bool canInteract = false;

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
            jetSound.SetActive(true);

        }
    }

    public void OnClick()
    {
        if (canInteract == true)
        {
            SceneManager.LoadScene(0);
        }
    }

}
