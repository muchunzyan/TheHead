using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class saw_destroy : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "DieZone")
            Destroy(this.gameObject);
    }
}
