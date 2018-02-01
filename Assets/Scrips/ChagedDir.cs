using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChagedDir : MonoBehaviour
{
   public Vector3 dir;
    float Velocity=5;
   

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Ball") )
        {
            Rigidbody2D rb;
            rb = col.GetComponent<Rigidbody2D>();
            rb.velocity = dir.normalized * Velocity;

        }


    }


}
