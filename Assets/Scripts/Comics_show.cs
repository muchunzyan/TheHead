using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Comics_show : MonoBehaviour
{
    public GameObject Disclaimer_text, picture1, picture2, picture3, picture4, Loading;

    private void Start()
    {
        PlayerPrefs.SetInt("Death", 0);
    }

    public void Show1()
    {
        Disclaimer_text.SetActive(false);
        picture1.SetActive(true);
    }

    public void Show2()
    {
        picture1.SetActive(false);
        picture2.SetActive(true);
    }

    public void Show3()
    {
        picture2.SetActive(false);
        picture3.SetActive(true);
    }

    public void Show4()
    {
        picture3.SetActive(false);
        picture4.SetActive(true);
    }

    public void LoadMenu()
    {
        picture4.SetActive(false);
        Loading.SetActive(true);
        SceneManager.LoadScene("MainMenu");
    }
}
