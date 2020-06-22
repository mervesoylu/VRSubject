﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public GameObject doorLight;
    public bool doorClicked = false;
    public Animator leftDoor;
    public Animator rightDoor;
    public float timer;
    float delay = 5;
    public float vaccuumTimer;
    public float vaccuumDelay = 0.1f;
    public GameObject panel;
    float sceneLoad = 8;
    public GameObject buttonSound;
    public GameObject vaccuumSound;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (doorClicked == true)
        {
            leftDoor.SetBool("isOpen", true);
            rightDoor.SetBool("isOpen", true);
            timer += Time.deltaTime;
            vaccuumTimer += Time.deltaTime;
            buttonSound.SetActive(true);

        }

        if (timer >= delay)
        {
            panel.SetActive(true);
            buttonSound.SetActive(false);
        }

        if (timer >= vaccuumDelay)
        {
            vaccuumSound.SetActive(true);
        }

        if (timer >= sceneLoad)
        {
            SceneManager.LoadScene(1);
        }

    }

    public void OnClick()
    {
        doorLight.GetComponent<Renderer>().material.color = Color.green;
        doorLight.GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.green);
        doorClicked = true;
    }

}
