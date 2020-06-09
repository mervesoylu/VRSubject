﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class oxygenTimer : MonoBehaviour
{
    public GameObject LosePanel;

    public Image oxgTimer;
    public float timer;
    public float maxTime = 60;

    public GameObject objectHandler;

    public bool time = true;

    void Update()
    {
        //timer starts counting down and the corresponding UI goes down with it
        if (time == true)
        {
            timer -= Time.deltaTime;
            var percent = timer / maxTime;
            oxgTimer.fillAmount = Mathf.Lerp(0, 1, percent);
        }

        //once the timer reacher 0, LosPanel it activated
        if (timer <= 0)
        {
            Debug.Log("YOU LOSE!");
            LosePanel.SetActive(true);
        }

        //if the player finds all the objects before the oxygen runs out, the timer is stopped
        if (objectHandler.GetComponent<ObjectHandler>().objectCount == objectHandler.GetComponent<ObjectHandler>().MaxObjects)
        {
            time = false;
            oxgTimer.fillAmount = timer/maxTime;
        }
    }
}
