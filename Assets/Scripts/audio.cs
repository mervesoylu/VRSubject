using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;

public class audio : MonoBehaviour
{
    public GameObject correct;
    

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnDestroy()
    {
        correct.SetActive(true);
    }



}
