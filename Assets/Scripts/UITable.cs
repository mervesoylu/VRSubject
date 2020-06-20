using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UITable : MonoBehaviour
{
    public GameObject player;


    void Update()
    {

        Vector3 eulerRotation = new Vector3(transform.eulerAngles.x, player.transform.eulerAngles.y, transform.eulerAngles.z);

        transform.rotation = Quaternion.Euler(eulerRotation);
    }
}
