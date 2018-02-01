using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{

    public float startVelocity=3;
    Rigidbody2D rb;


    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Iniciar();
    }



    void Iniciar()
    {
        transform.position = Vector3.zero;
        rb.velocity = new Vector3(Random.Range(-1, 2) * startVelocity, -startVelocity);
    }


    private void Update()
    {
        if (transform.position.y <= -6.31)
        {
            //Debug.Log("21");
            Iniciar();
        }

    }


}


