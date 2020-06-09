using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoonFloater : MonoBehaviour
{
    private float PlanetRotateSpeed;
    private float OrbitSpeed;


    void Start()
    {
        OrbitSpeed = Random.Range(0.5f, 5);

    }

    void Update()
    {
        transform.RotateAround(Vector3.zero, Vector3.up, OrbitSpeed * Time.deltaTime);

    }
}
