using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    public GameObject doorLight;
    public bool doorClicked = false;
    public Animator doorOpen;

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
        }
    }

    public void OnClick()
    {
        doorLight.GetComponent<Renderer>().material.color = Color.green;
        doorLight.GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.green);
        doorClicked = true;
    }

}
