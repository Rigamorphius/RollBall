using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public float speed;

    private Rigidbody rb;

    void Start() {

        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        float MoveHorizontal = Input.GetAxis("Horizontal");
        float MoveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(MoveHorizontal,0.0f,MoveVertical);

        rb.AddForce(movement * speed);
    }
}
