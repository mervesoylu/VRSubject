using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionBehaviour : MonoBehaviour
{
    public Transform target;
    public float speed = 2;
    private bool buttonPressed = false;

    public bool addToCount = false;

    public GameObject objectHandler;
    public GameObject oxygenTimer;

    private bool decrease = false;
    public float decreaseTime = 5.0f;
    private bool increase = false;
    public float increaseTime = 5.0f;

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

        if ((transform.position == target.transform.position) && (tag == "ObjectsToFind"))
        {
            addToCount = true;
        }

        if (addToCount == true)
        {
            objectHandler.GetComponent<ObjectHandler>().objectCount++;
            Destroy(gameObject);
        }

        if ((transform.position == target.transform.position) && (tag == "OtherObjects"))
        {
            decrease = true;
        }

        if (decrease == true)
        {
            oxygenTimer.GetComponent<oxygenTimer>().timer -= decreaseTime;
            Destroy(gameObject);
            decrease = false;
        }

        if ((transform.position == target.transform.position) && (tag == "Oxygen"))
        {
            increase = true;
        }

        if (increase == true)
        {
            oxygenTimer.GetComponent<oxygenTimer>().timer += increaseTime;
            Destroy(gameObject);
            increase = false;
        }
    }

}
