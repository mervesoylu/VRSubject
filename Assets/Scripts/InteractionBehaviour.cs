using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class InteractionBehaviour : MonoBehaviour
{
    public Transform target;
    public float speed = 10;
    private bool buttonPressed = false;


    public GameObject objectHandler;
    public GameObject oxygenTimer;
    public GameObject timer;
    public GameObject timerbg;
    public GameObject PostIt;

    private bool decrease = false;
    public float decreaseTime = 5f;
    private bool increase = false;
    public float increaseTime = 5f;

    public Transform trash;


    IEnumerator ChangeColor()
    {
        yield return new WaitForSeconds(1);
        timer.GetComponent<Image>().color = new Color(0, 255, 247);
        timerbg.GetComponent<Image>().color = Color.black;
    }

    IEnumerator NoteChange()
    {
        yield return new WaitForSeconds(1);
        PostIt.GetComponent<Image>().color = new Color(255, 255, 255);
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
            StartCoroutine(MoveToTrash());
            buttonPressed = false;
        }

        //once the object reaches the player, and its tag is "OtherObjects", descrease becomes true
        if ((transform.position == target.transform.position) && (tag == "OtherObjects"))
        {
            decrease = true;
            buttonPressed = false;
        }
        //and the player loses some oxygen and the object is destroyed
        if (decrease == true)
        {
            oxygenTimer.GetComponent<oxygenTimer>().timer -= decreaseTime * Time.deltaTime;
            StartCoroutine(MoveToTrash());
            timer.GetComponent<Image>().color = Color.red;
            timerbg.GetComponent<Image>().color = new Color32(139, 0, 0, 255);
            StartCoroutine(ChangeColor());

            PostIt.GetComponent<Image>().color = Color.red;
            StartCoroutine(NoteChange());

            decrease = false;
        }

        //once the object reaches the player, and its tag is "Oxygen", increase becomes true
        if ((transform.position == target.transform.position) && (tag == "Oxygen"))
        {
            increase = true;
            buttonPressed = false;
        }
        //and the player gains oxygen and the object is destroyed
        if (increase == true)
        {
            oxygenTimer.GetComponent<oxygenTimer>().timer += increaseTime * Time.deltaTime;
            StartCoroutine(MoveToTrash());
            timer.GetComponent<Image>().color = Color.green;
            timerbg.GetComponent<Image>().color = new Color32(0, 100, 0, 255);
            StartCoroutine(ChangeColor());
            increase = false;
        }
    }


    IEnumerator MoveToTrash()
    {
        yield return new WaitForSeconds(1f);
        transform.position = trash.position;
    }

}
