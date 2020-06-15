using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class correctAudio : MonoBehaviour
{
    public GameObject correct;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (correct == true)
        {
            Invoke("Off()", 1);
        }
    }

    public void Off()
    {
        correct.SetActive(false);
    }
}
