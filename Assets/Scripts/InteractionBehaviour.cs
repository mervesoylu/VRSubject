using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionBehaviour : MonoBehaviour
{
    public Transform target;
    public float speed = 2;
    private bool buttonPressed = false;

    public void ButtonClick()
    {
        buttonPressed = true;
    }

    public void OnEnter()
    {
       var fscript = GetComponent<floater>();
        fscript.enabled = false;
    }

    public void OnExit()
    {
       var fscript = GetComponent<floater>();
        fscript.enabled = true;
    }

    private void Update()
    {
        if(buttonPressed == true)
        {
            float step = speed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, target.position, step);

            var fscript = GetComponent<floater>();
            fscript.enabled = false;
        }
    }
}
