using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class oxygenTimer : MonoBehaviour
{
    public Image oxgTimer;
    public float timer;
    public float maxTime = 60;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        var percent = timer / maxTime;
        oxgTimer.fillAmount = Mathf.Lerp(0, 1, percent);
    }
}
