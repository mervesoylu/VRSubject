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
        //randomises the degrees of rotation for each object
        PlanetRotateSpeed = Random.Range(-90, 90);
        OrbitSpeed = Random.Range(5, 15);
        //randomises the speed objects move up and down for each object
        speed = Random.Range(.0001f, 0.001f);

    }

    void Update()
    {
        //rotates the object on its own axis as well as around the Vector(0,0,0)
        transform.Rotate(transform.up * PlanetRotateSpeed * Time.deltaTime);
        transform.RotateAround(Vector3.zero, Vector3.up, OrbitSpeed * Time.deltaTime);

        //moves the object up and down creating a bouncing effect
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