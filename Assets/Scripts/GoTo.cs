using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoTo : MonoBehaviour
{
    public GameObject YouDidIt_text, Loading;

    private void Start()
    {
        if (PlayerPrefs.GetInt("YouDidIt") == 1)
            YouDidIt_text.SetActive(true);
    }
    public void GoHome()
    {
        Loading.SetActive(true);
        Time.timeScale = 1;
        SceneManager.LoadScene("MainMenu");
    }

    public void GoLevels()
    {
        Loading.SetActive(true);
        Time.timeScale = 1;
        SceneManager.LoadScene("LevelsMenu");
    }

    public void GoLevel1()
    {
        Loading.SetActive(true);
        SceneManager.LoadScene("Level1");
    }

    public void GoLevel2()
    {
        Loading.SetActive(true);
        SceneManager.LoadScene("Level2");
    }

    public void GoLevel3()
    {
        Loading.SetActive(true);
        SceneManager.LoadScene("Level3");
    }

    public void GoLevel4()
    {
        Loading.SetActive(true);
        SceneManager.LoadScene("Level4");
    }

    public void GoLevel5()
    {
        Loading.SetActive(true);
        SceneManager.LoadScene("Level5");
    }

    public void GoLevel6()
    {
        Loading.SetActive(true);
        SceneManager.LoadScene("Level6");
    }

    public void GoLevel7()
    {
        Loading.SetActive(true);
        SceneManager.LoadScene("Level7");
    }

    public void GoLevel8()
    {
        Loading.SetActive(true);
        SceneManager.LoadScene("Level8");
    }

    public void GoLevel9()
    {
        Loading.SetActive(true);
        SceneManager.LoadScene("Level9");
    }

    public void GoLevel10()
    {
        Loading.SetActive(true);
        SceneManager.LoadScene("Level10");
    }
}
