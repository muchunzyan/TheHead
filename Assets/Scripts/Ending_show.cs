using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ending_show : MonoBehaviour
{
    public GameObject picture1, picture2, picture3, picture4, picture5, picture6, picture7, picture8, Loading;

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

    public void Show5()
    {
        picture4.SetActive(false);
        picture5.SetActive(true);
    }

    public void Show6()
    {
        picture5.SetActive(false);
        picture6.SetActive(true);
    }

    public void Show7()
    {
        picture6.SetActive(false);
        picture7.SetActive(true);
    }

    public void Show8()
    {
        picture7.SetActive(false);
        picture8.SetActive(true);
    }

    public void LoadMenu()
    {
        picture8.SetActive(false);
        Loading.SetActive(true);
        SceneManager.LoadScene("MainMenu");
    }
}
