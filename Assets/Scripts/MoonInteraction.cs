﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoonInteraction : MonoBehaviour
{
    public GameObject Player;
    public Transform target;

    public float speed = 2;
    private bool isPressed = false;

    public void OnClick()
    {
        isPressed = true;
    }

    void Update()
    {
        if(isPressed == true)
        {
            //when the player presses the button on another moon, they move towards the target gameobject on that moon
            float step = speed * 100 * Time.deltaTime;
            Player.transform.position = Vector3.MoveTowards(Player.transform.position, target.position, step);
        }

        if(Player.transform.position == target.position)
        {
            isPressed = false;
        }
       
    }
}
