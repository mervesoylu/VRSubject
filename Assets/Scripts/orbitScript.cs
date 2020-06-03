using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class orbitScript : MonoBehaviour
{
    public float rotOffset;

    // Start is called before the first frame update
    void Start()
    {
        rotOffset = Random.Range(-15, 50);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(0f, Time.deltaTime * rotOffset, 0f), Space.World);

    }
}
