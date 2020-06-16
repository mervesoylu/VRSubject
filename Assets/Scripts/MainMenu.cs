using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public GameObject doorLight;
    public bool doorClicked = false;
    public Animator doorOpen;
    public float timer;
    public float delay = 5;
    public float vaccuumTimer;
    public float vaccuumDelay = 1;
    public GameObject panel;
    public float sceneLoad = 8;
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
            doorOpen.SetBool("isOpen", true);
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
