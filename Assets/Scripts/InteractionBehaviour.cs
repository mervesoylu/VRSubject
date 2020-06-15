using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class InteractionBehaviour : MonoBehaviour
{
    public Transform target;
    public float speed = 2;
    private bool buttonPressed = false;

    public bool addToCount = false;

    public GameObject objectHandler;
    public GameObject oxygenTimer;
    public GameObject timer;
    public GameObject timerbg;

    private bool decrease = false;
    public float decreaseTime = 5.0f;
    private bool increase = false;
    public float increaseTime = 5.0f;

    public Transform trash;

    public void ChangeColor()
    {
        timer.GetComponent<Image>().color = new Color(0, 255, 247);
        timerbg.GetComponent<Image>().color = Color.black;
        Debug.Log("COLOR HAS CHANGED!");
    }

    public void ButtonClick()
    {
        buttonPressed = true;
    }

    //stops the floater script when player hovers over an object
    public void OnEnter()
    {
       var fscript = GetComponent<floater>();
       fscript.enabled = false;
    }

    //turns the floater script back on when player is no longer hovering over an object
    public void OnExit()
    {
       var fscript = GetComponent<floater>();
        fscript.enabled = true;
    }

    private void Update()
    {
        //when the button is pressed the object begins to move towards the player and the floater script is disabled
        if(buttonPressed == true)
        {
            float step = speed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, target.position, step);

            var fscript = GetComponent<floater>();
            fscript.enabled = false;
        }

        //once the object reaches the player, and its tag is "ObjectsToFind", addToCount becomes true
        if ((transform.position == target.transform.position) && (tag == "ObjectsToFind"))
        {
            addToCount = true;
        }
        //and a point is added to the objectCount and the object is destroyed
        if (addToCount == true)
        {
            objectHandler.GetComponent<ObjectHandler>().objectCount++;
            Destroy(gameObject);
        }


        //once the object reaches the player, and its tag is "OtherObjects", descrease becomes true
        if ((transform.position == target.transform.position) && (tag == "OtherObjects"))
        {
            decrease = true;
        }
        //and the player loses some oxygen and the object is destroyed
        if (decrease == true)
        {
            oxygenTimer.GetComponent<oxygenTimer>().timer -= decreaseTime;
            transform.position = trash.position;
            timer.GetComponent<Image>().color = Color.red;
            timerbg.GetComponent<Image>().color = new Color32(139, 0, 0, 255);
            Invoke("ChangeColor" , 1);
            decrease = false;
        }

        //once the object reaches the player, and its tag is "Oxygen", increase becomes true
        if ((transform.position == target.transform.position) && (tag == "Oxygen"))
        {
            increase = true;
        }
        //and the player gains oxygen and the object is destroyed
        if (increase == true)
        {
            oxygenTimer.GetComponent<oxygenTimer>().timer += increaseTime;
            transform.position = trash.position;
            timer.GetComponent<Image>().color = Color.green;
            timerbg.GetComponent<Image>().color = new Color32(0, 100, 0, 255);
            Invoke("ChangeColor", 1);
            increase = false;
        }
    }

}
