using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseGame : MonoBehaviour
{
    public GameObject pauseLay, Loading;
    public AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();

        pauseLay.SetActive(false);
    }

    public void Pause()
    {
        Time.timeScale = 0;
        pauseLay.SetActive(true);
        audioSource.Pause();
    }

    public void Play()
    {
        Time.timeScale = 1;
        pauseLay.SetActive(false);

        if (PlayerPrefs.GetInt("Sound") == 1)
            audioSource.Play();
    }

    public void Retry()
    {
        Loading.SetActive(true);
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
