using UnityEngine;
using System.Collections;

/// <summary>
///Missle class
///---------------------------------------------
///This class will control the missle's behavior
///Created 8/15/2018
///Author Riley Chadwick
/// </summary>


public class missile : MonoBehaviour
{

    public Vector2 touchPos;
    public float touchRadius = 0.1f;
    public float speed = 1;
    public bool active = false;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        //Basic method to move the missile to the player touch pos
        //TODO:::::
        ////Get Acceleration code so the missle will gain speed as it flys
        ////Get Rotation code so the missle will rotate to point to the touchPos


        if (Input.GetMouseButtonDown(0))
        {
            active = true;
            touchPos = Input.mousePosition;
            Debug.Log("INFO: Mouse Pos " + Input.mousePosition);
        }

        if(Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved)
        {
            active = true;
            touchPos = Input.GetTouch(0).position;
        }


        if (active)
        {
            if (Vector2.Distance(touchPos, transform.position) < touchRadius)
            {
                Debug.Log("Reached Touch Postiion");
            }
            transform.position = Vector2.MoveTowards(transform.position, touchPos, Time.deltaTime * speed);
        }



    }
}
