using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gazeTimer : MonoBehaviour
{
    public Image imgGaze;

    public float totalTime = 3;
    bool gvrStatus;
    public float timer;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (gvrStatus == true)
        {
            timer += Time.deltaTime;
            imgGaze.fillAmount = timer / totalTime;
        }
    }

    public void GVROn()
    {
        gvrStatus = true;
    }

    public void GVROff()
    {
        gvrStatus = false;
        timer = 0;
        imgGaze.fillAmount = 0;
    }
}
