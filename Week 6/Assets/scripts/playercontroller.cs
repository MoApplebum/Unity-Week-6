using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class playercontroller : MonoBehaviour
{
    private Rigidbody rb;
    private float movementX;
    private float movementY;
    public float speed = 0;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // get vector2 value from the movements data and stores it in a vector2 variable called "movement vector"
    void OnMove(InputValue MovementValue)
    {
        Vector2 movementvector = MovementValue.Get<Vector2>();
        movementX = movementvector.x;
        movementY = movementvector.y;
    }


    void FixedUpdate()
    {
        Vector3 movement = new Vector3(movementX, 0.0f, movementY);
        rb.AddForce(speed*movement);
    }

    // Update is called once per frame

}
