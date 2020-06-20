using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class oxygenTimer : MonoBehaviour
{
    public GameObject LosePanel;

    public Image oxgTimer;
    public float timer;
    public float maxTime = 60;

    public GameObject objectHandler;
    public GameObject breatheSound;

    public GameObject Reticle;

    public bool time = true;
    public bool panel = false;

    IEnumerator waitTime()
    {
        yield return new WaitForSeconds(5);
        SceneManager.LoadScene(1);
    }

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
            panel = true;
            breatheSound.SetActive(false);

        }

        if (timer <= 20)
        {
            breatheSound.SetActive(true);
        }

        if (timer >= 21)
        {
            breatheSound.SetActive(false);
        }

        //if the player finds all the objects before the oxygen runs out, the timer is stopped
        if (objectHandler.GetComponent<ObjectHandler>().ObjectsToFind.Count == 0)
        {
            time = false;
            oxgTimer.fillAmount = timer/maxTime;
        }

        if (timer > maxTime)
        {
            timer = maxTime;
        }

        if (panel == true)
        {
            StartCoroutine(waitTime());
            Reticle.SetActive(false);
        }
    }
}
