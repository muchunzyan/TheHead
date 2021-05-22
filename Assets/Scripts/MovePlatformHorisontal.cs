using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlatformHorisontal : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed = 2;
    public int direct = 1;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (this.name == "saw1")
        {
            if (transform.position.x < 71.8)
            {
                direct = 1;
            }

            if (transform.position.x > 85.25)
            {
                direct = -1;
            }
        }

        if (this.name == "saw2")
        {
            if (transform.position.x < 56.63)
            {
                direct = 1;
            }

            if (transform.position.x > 70.25)
            {
                direct = -1;
            }
        }

        if (this.name == "saw3")
        {
            if (transform.position.x < 19.2)
            {
                direct = 1;
            }

            if (transform.position.x > 27)
            {
                direct = -1;
            }
        }

        if (this.name == "Horizontal_with_die")
        {
            if (transform.position.x < 7.4)
            {
                direct = 1;
            }

            if (transform.position.x > 18.96)
            {
                direct = -1;
            }
        }

        if (this.name == "moving_u")
        {
            if (transform.position.x < 103.74)
            {
                direct = 1;
            }

            if (transform.position.x > 114.41)
            {
                direct = -1;
            }
        }

        rb.velocity = new Vector2(speed * direct, rb.velocity.y);
    }
}
