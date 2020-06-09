using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class randomisation : MonoBehaviour
{
    public GameObject[] allObjects;
    

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < allObjects.Length; i++)
        {
            Random.Range(0, (allObjects.Length));
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
