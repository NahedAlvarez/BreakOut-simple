using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public Rigidbody2D rb;
    public float velocity;



    void Update ()
    {

        rb.velocity = new Vector3(Input.GetAxis("Horizontal") * velocity, 0);
       // transform.position = new Vector3(Input.GetAxis("Horizontal") * velocity, 0); 

	}
}
