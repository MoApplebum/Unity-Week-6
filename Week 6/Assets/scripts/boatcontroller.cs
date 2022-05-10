using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class boatcontroller : MonoBehaviour
{
    private Rigidbody rb;
    public Transform cam;
    private Vector3 mvmt;
    public float speed = 0;
    public float gravity;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void OnMove(InputValue MovementValue)
    {
        Vector2 movementraw = MovementValue.Get<Vector2>();
        Vector3 camF = new Vector3(cam.forward.x, 0, cam.forward.z);
        Vector3 camR = new Vector3(cam.right.x, 0, cam.right.z);
        mvmt = ((camF * movementraw.y) + (camR * movementraw.x)).normalized * speed;
    }


    void Update()
    {
        mvmt.y += gravity;
        transform.position += (mvmt * Time.deltaTime);
    }



}
