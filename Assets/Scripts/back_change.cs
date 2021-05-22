using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class back_change : MonoBehaviour
{
    public GameObject back_red, back_blue;
    public float color_time;

    void Update()
    {
        color_time += Time.deltaTime;

        if (color_time % 1 > 0 && color_time % 1 < 0.5)
        {
            back_red.SetActive(true);
            back_blue.SetActive(false);
        }

        if (color_time % 1 > 0.5 && color_time % 1 < 1)
        {
            back_red.SetActive(false);
            back_blue.SetActive(true);
        }
    }
}
