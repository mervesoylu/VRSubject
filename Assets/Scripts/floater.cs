// Floater v0.0.2
// by Donovan Keith
//
// [MIT License](https://opensource.org/licenses/MIT)

using UnityEngine;
using System.Collections;

// Makes objects float up & down while gently spinning.
public class floater : MonoBehaviour
{
    // User Inputs
    public float degreesPerSecond = 0;
    public float amplitude = 0;
    public float frequency = 1f;

    private float timeOffset = 0;

    // Position Storage Variables
    Vector3 posOffset = new Vector3();
    Vector3 tempPos = new Vector3();

    // Use this for initialization
    void Start()
    {
        // Store the starting position & rotation of the object
         posOffset = transform.position;

        timeOffset = Random.Range(0, 10);
        amplitude = Random.Range(0.1f, 0.4f);
        degreesPerSecond = Random.Range(15, 30);
    }

    // Update is called once per frame
    void Update()
    {
        // Spin object around Y-Axis
        transform.Rotate(new Vector3(0f, Time.deltaTime * degreesPerSecond, 0f));

        // Float up/down with a Sin()
        tempPos = posOffset;
        tempPos.y += Mathf.Sin(Time.fixedTime * Mathf.PI * frequency + timeOffset) * amplitude;
        

        transform.position = tempPos;
    }
}