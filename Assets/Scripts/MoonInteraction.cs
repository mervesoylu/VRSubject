using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoonInteraction : MonoBehaviour
{
    public GameObject Player;
    public GameObject target;

    public void OnClick()
    {
        Player.transform.position = target.transform.position;
    }
}
