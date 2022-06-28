using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClawBase : MonoBehaviour
{
    [SerializeField] float accel;
    [SerializeField] float max_vel;
    [SerializeField] float friction;
    [SerializeField] float elasticity;
    Vector3 vel;

    // Update is called once per frame
    void Update()
    {
        float wish = 0;
        if (Input.GetKey(KeyCode.A))
        {
            wish = -accel * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.D))
        {
            wish = accel * Time.deltaTime;
        }
        if((wish == 0 || Mathf.Sign(vel.x) != Mathf.Sign(wish)) && vel.x != 0)
        {
            if (Mathf.Abs(vel.x) < 0.1f)
                vel.x = 0;
            else
                wish += -Mathf.Sign(vel.x) * friction * Time.deltaTime;
        }

        vel.x += wish;
        vel.x = Mathf.Min(vel.x, max_vel);
        vel.x = Mathf.Max(vel.x, -max_vel);
        transform.position += vel * Time.deltaTime;


        if (transform.position.x > 8)
        {
            Vector3 p = transform.position;
            p.x = 7.9f;
            transform.position = p;
            vel *= -elasticity;
        }
        if (transform.position.x < -8)
        {
            Vector3 p = transform.position;
            p.x = -7.9f;
            transform.position = p;
            vel *= -elasticity;
        }

    }
}
