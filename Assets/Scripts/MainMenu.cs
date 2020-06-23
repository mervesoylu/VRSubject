using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public GameObject doorLight;
    public bool doorClicked = false;
    public float timer;
    float delay = 5;
    public float vaccuumTimer;
    public float vaccuumDelay = 0.1f;
    public GameObject panel;
    float sceneLoad = 8;
    public GameObject buttonSound;
    public GameObject vaccuumSound;

    public List<Animator> animations;

    public CameraShake cameraShake;


    // Update is called once per frame
    void Update()
    {
        if (doorClicked == true)
        {
            timer += Time.deltaTime;
            vaccuumTimer += Time.deltaTime;
            buttonSound.SetActive(true);

            foreach (Animator anim in animations)
            {
                anim.SetBool("isOpen", true);
            }

            StartCoroutine(cameraShake.Shake(5f, 0.02f));

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
