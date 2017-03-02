using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public int layerToIgnoreRayCast;
    //which layer will be ignored by the raycast
    public float rayLength = 5.0f;
    // length of the raycast
    public float moveSpeed = 1.0f;
    // player speed multiplier

    Rigidbody2D playerRB;


    // Use this for initialization
    void Start ()
    {
        playerRB = GetComponent<Rigidbody2D> ();    // assign player rigidbody component to this variable.
    }
	
    // Update is called once per frame
    void Update ()
    {

        //handle player input by using the horiontal axis -- this means that WASD & arrow keys will work
        // also gamepads, etc.
        float input = Input.GetAxis ("Horizontal") * moveSpeed;
        playerRB.AddForce (Vector2.right * input, ForceMode2D.Impulse); //Vector2.right = (1,0)


        // the raycast should ignore the player object because we don't want it 
        // colliding with itself
        layerToIgnoreRayCast = LayerMask.NameToLayer ("Player"); // or use layer number layerToIgnoreRayCast = 8
        int layerMask = ~(1 << layerToIgnoreRayCast);


        // get the actual mouse position, in world coordinates
        Vector3 actualMousePosition = Camera.main.ScreenToWorldPoint (Input.mousePosition);


        // create a ray which goes from transform.position to the direction of the mouse position
        // the length is rayLength
        // it ignores the layerMask
        RaycastHit2D hit = Physics2D.Raycast (transform.position, 
                               new Vector2 (actualMousePosition.x - transform.position.x, actualMousePosition.y - transform.position.y), 
                               rayLength, 
                               layerMask);
        

        // set Color to red, in preparation for drawing a debug line
        Color c = Color.red;

        // if there's a hit, then print out name of object and set the color to green
        if (hit.collider != null) {
            Debug.Log (hit.collider.gameObject.name);
            c = Color.green;
        }


        //draw debug line
        Debug.DrawLine (transform.position, new Vector2 (actualMousePosition.x, actualMousePosition.y), c);


    }
}
