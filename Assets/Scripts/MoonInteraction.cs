using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoonInteraction : MonoBehaviour
{
    public GameObject Player;
    public GameObject target;

    public void OnClick()
    {
        //when the player presses the button on another moon, they are teleported to a target gameobject on that moon
        Player.transform.position = target.transform.position;
    }
}
