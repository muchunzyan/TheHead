using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class disapp_platform : MonoBehaviour
{
    public float timeLeft = 1;
    public bool gronded = false;
    void Update()
    {
        if (gronded)
        {
            timeLeft -= Time.deltaTime;
            if (timeLeft < 0)
            {
                RemovePlatform();
            }
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            gronded = true;
        }
    }

    public void RemovePlatform()
    {
        this.gameObject.SetActive(false);
    }
}
