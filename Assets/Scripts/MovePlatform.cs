using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlatform : MonoBehaviour
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
        if (this.name == "up-down_with_die")
        {
            if (transform.position.y > 12.64)
            {
                direct = -1;
            }

            if (transform.position.y < 1.55)
            {
                direct = 1;
            }
        }

        if (this.name == "up-down_with_die (1)")
        {
            if (transform.position.y > 2)
            {
                direct = -1;
            }

            if (transform.position.y < -1.82)
            {
                direct = 1;
            }
        }

        if (this.name == "up-down_with_die (2)")
        {
            if (transform.position.y > 18.1)
            {
                direct = -1;
            }

            if (transform.position.y < 14.12)
            {
                direct = 1;
            }
        }

        if (this.name == "platform_up-down (1)")
        {
            if (transform.position.y > -0.31)
            {
                direct = -1;
            }

            if (transform.position.y < -19.17)
            {
                direct = 1;
            }
        }

        if (this.name == "platform_up-down (2)")
        {
            if (transform.position.y > 17.8)
            {
                direct = -1;
            }

            if (transform.position.y < 4.26)
            {
                direct = 1;
            }
        }

        if (this.name == "platform_up-down (3)")
        {
            if (transform.position.y > 21.9)
            {
                direct = -1;
            }

            if (transform.position.y < 0)
            {
                direct = 1;
            }
        }

        if (this.name == "up-down_with_die (4)")
        {
            if (transform.position.y > 20)
            {
                direct = -1;
            }

            if (transform.position.y < 14.22)
            {
                direct = 1;
            }
        }

        if (this.name == "platform_up-down (4)")
        {
            if (transform.position.y > 12.73)
            {
                direct = -1;
            }

            if (transform.position.y < 5.26)
            {
                direct = 1;
            }
        }

        if (this.name == "platform_up-down (5)")
        {
            if (transform.position.y > -7)
            {
                direct = -1;
            }

            if (transform.position.y < -12.73)
            {
                direct = 1;
            }
        }

        rb.velocity = new Vector2(rb.velocity.x, speed * direct);
    }
}
