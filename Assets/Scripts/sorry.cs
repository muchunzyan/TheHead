using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sorry : MonoBehaviour
{
    public GameObject sorry_group;
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            sorry_group.SetActive(true);
        }
    }
}
