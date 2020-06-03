// Floater v0.0.2
// by Donovan Keith
//
// [MIT License](https://opensource.org/licenses/MIT)

using UnityEngine;
using System.Collections;


public class floater : MonoBehaviour
{
    private float PlanetRotateSpeed;
    private float OrbitSpeed;

    private bool up = true;
    private float speed;

    void Start()
    {
        PlanetRotateSpeed = Random.Range(-90, 90);
        OrbitSpeed = Random.Range(5, 15);

        speed = Random.Range(.0001f, 0.015f);

    }

    void Update()
    {
        transform.Rotate(transform.up * PlanetRotateSpeed * Time.deltaTime);
        transform.RotateAround(Vector3.zero, Vector3.up, OrbitSpeed * Time.deltaTime);

        var temp = transform.position;
        if (up == true)
        {
            temp.y += speed;
            transform.position = temp;
            if (transform.position.y >= 1.75f)
            {
                up = false;
            }
        }
        if (up == false)
        {
            temp.y -= speed;
            transform.position = temp;
            if (transform.position.y <= 1.25f)
            {
                up = true;
            }
        }
    }
}