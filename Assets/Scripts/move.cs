using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.Advertisements;

public class move : MonoBehaviour
{
    public Rigidbody2D rb;
    public float playerSpeed;
    public float jumpPower;
    public int directionInput;
    public int jumps = 0;
    public GameObject GameOver;
    public GameObject btn_pause, btnLeft, btnRight, btnUp, btnMap;
    public int gravity = 0;

    void Start()
    {
        if (Advertisement.isSupported)
            Advertisement.Initialize("3416876", false);

        rb = GetComponent<Rigidbody2D>();
        Physics2D.gravity = new Vector2(0, -9.81f);
    }

    void FixedUpdate()
    {
        rb.velocity = new Vector2(playerSpeed * directionInput, rb.velocity.y);
    }

    public void Move(int InputAxis)
    {
        directionInput = InputAxis;
    }

    public void Jump(bool isJump)
    {
        if (jumps > 0)
        {
            if (gravity % 2 == 0)
                rb.velocity = new Vector2(rb.velocity.x, jumpPower);
            if (gravity % 2 == 1)
                rb.velocity = new Vector2(rb.velocity.x, -jumpPower);
            jumps--;
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Ground" || other.tag == "Disapp")
        {
            jumps = 2;
        }

        if (other.tag == "DieZone")
        {
            Time.timeScale = 0;
            btn_pause.SetActive(false);
            btnLeft.SetActive(false);
            btnRight.SetActive(false);
            btnUp.SetActive(false);
            btnMap.SetActive(false);
            GameOver.SetActive(true);
            PlayerPrefs.SetInt("Death", PlayerPrefs.GetInt("Death") + 1);

            //Advertisements
            /*
            if (PlayerPrefs.GetInt("Death") == 3)
            {
                if (Advertisement.IsReady("video"))
                {
                    Advertisement.Show("video");
                }

                PlayerPrefs.SetInt("Death", 0);
            }
            */
        }

        if (other.tag == "Fake")
        {
            other.gameObject.SetActive(false);
        }

        if (other.tag == "ch_gravity")
        {
            if (gravity % 2 == 0)
            {
                Physics2D.gravity = new Vector2(0, 9.81f);
            }
            if (gravity % 2 == 1)
            {
                Physics2D.gravity = new Vector2(0, -9.81f);
            }

            gravity++;
        }
    }
}
