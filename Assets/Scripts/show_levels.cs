using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class show_levels : MonoBehaviour
{
    public GameObject lv1, lv2, lv3, lv4, lv5, lv6, lv7, lv8, lv9, lv10;
    void Start()
    {
        if (PlayerPrefs.GetInt("Level1") == 1)
            lv2.SetActive(true);

        if (PlayerPrefs.GetInt("Level2") == 1)
            lv3.SetActive(true);

        if (PlayerPrefs.GetInt("Level3") == 1)
            lv4.SetActive(true);

        if (PlayerPrefs.GetInt("Level4") == 1)
            lv5.SetActive(true);

        if (PlayerPrefs.GetInt("Level5") == 1)
            lv6.SetActive(true);

        if (PlayerPrefs.GetInt("Level6") == 1)
            lv7.SetActive(true);

        if (PlayerPrefs.GetInt("Level7") == 1)
            lv8.SetActive(true);

        if (PlayerPrefs.GetInt("Level8") == 1)
            lv9.SetActive(true);

        if (PlayerPrefs.GetInt("Level9") == 1)
            lv10.SetActive(true);
    }
}
