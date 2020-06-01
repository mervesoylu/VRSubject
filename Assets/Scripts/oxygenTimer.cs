using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class oxygenTimer : MonoBehaviour
{
    public Image oxgTimer;
    public float timer;
    public float maxTime = 60;

    public GameObject objectHandler;

    public bool time = true;

    void Update()
    {
        if (time == true)
        {
            timer -= Time.deltaTime;
            var percent = timer / maxTime;
            oxgTimer.fillAmount = Mathf.Lerp(0, 1, percent);
        }

        if (timer <= 0)
        {
            Debug.Log("YOU LOSE!");
        }

        if (objectHandler.GetComponent<ObjectHandler>().objectCount == objectHandler.GetComponent<ObjectHandler>().MaxObjects)
        {
            time = false;
            oxgTimer.fillAmount = timer/maxTime;
        }
    }
}
