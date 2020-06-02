using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject doorLight;
    public bool doorClicked = false;
    public Animator doorOpen;
    public float timer;
    public float delay = 5;
    public GameObject panel;
    public float sceneLoad = 8;

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
        }

        if (timer >= delay)
        {
            panel.SetActive(true);
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
