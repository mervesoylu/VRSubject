using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuItemsBehaviour : MonoBehaviour
{
    public GameObject door;
    public Transform flyTo;
    private bool newPosition = true;
    private bool fly = false;

    private float speed;

    private float randX;
    private float randY;
    private float randZ;

    void Start()
    {
        randX = Random.Range(-5, 5);
        randY = Random.Range(-0.1f, 0.1f);
        randZ = Random.Range(-5, 5);
        speed = Random.Range(5f, 10f);
    }

    void Update()
    {
        if ((door.GetComponent<MainMenu>().doorClicked == true) && (newPosition == true))
        {
            transform.position = new Vector3(randX, randY, randZ);
            fly = true;
            newPosition = false;
        }

        if (fly == true)
        {
            float step = speed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, flyTo.position, step);
        }
    }
}
