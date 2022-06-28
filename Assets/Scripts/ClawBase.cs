using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClawBase : MonoBehaviour
{
    Rigidbody2D rb;
    [SerializeField] float accel;
    [SerializeField] float chain_reel_speed;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();    
    }

    // Update is called once per frame
    float chain_slack = 1;
    void Update()
    {
        Vector2 vel = rb.velocity;
        if (Input.GetKey(KeyCode.A))
        {
            vel.x -= accel;
        }
        if (Input.GetKey(KeyCode.D))
        {
            vel.x += accel;
        }
        if (Input.GetKey(KeyCode.W))
        {
            chain_slack += chain_reel_speed;
        }
        if (Input.GetKey(KeyCode.S))
        {
            chain_slack += chain_reel_speed;
        }

        rb.velocity = vel;
    }
}
