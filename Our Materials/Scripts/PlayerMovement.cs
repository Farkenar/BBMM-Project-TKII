using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    public float Speed;
    public float movement;
    Rigidbody2D rb;
    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody2D>();
    }
	
	// Update is called once per frame
	void Update () {
        movement = Input.GetAxis("Horizontal");
        rb.velocity = new Vector3(movement, rb.velocity.y, 0);

    }
}
