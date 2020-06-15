using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;

public class audio : MonoBehaviour
{
    public GameObject incorrect;
    public GameObject correct;
    public Transform trash;
    public Transform Player;

    public bool buttonPressed;

    void Update()
    {
        if ((tag == "OtherObjects") && (buttonPressed == true) && (transform.position == Player.position))
        {
            incorrect.SetActive(true);
            buttonPressed = false;
        }

        if (transform.position == trash.position)
        {
            incorrect.SetActive(false);
            gameObject.SetActive(false);
        }

        if ((tag == "ObjectsToFind") && (buttonPressed == true) && (transform.position == Player.position))
        {
            correct.SetActive(true);
            buttonPressed = false;
        }

        if (transform.position == trash.position)
        {
            correct.SetActive(false);
            gameObject.SetActive(false);
        }
    }

    public void OnClick()
    {
        buttonPressed = true;
    }



}
