using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class audioOther : MonoBehaviour
{
    public GameObject incorrect;
    public Transform trash;

    public bool buttonPressed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (tag == "OtherObjects" && buttonPressed == true)
        {
            incorrect.SetActive(true);
            Debug.Log(incorrect.gameObject);
        }

        if (transform.position == trash.position)
        {
            incorrect.SetActive(false);
            Debug.Log("?");
        }
    }



    public void OnClick()
    {
        buttonPressed = true;
    }
}
