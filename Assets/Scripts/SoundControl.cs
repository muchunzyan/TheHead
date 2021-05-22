using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SoundControl : MonoBehaviour
{
    public GameObject soundOn, soundOff;
    public AudioSource audioSource;
    private Scene scene;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        scene = SceneManager.GetActiveScene();

        if (PlayerPrefs.GetInt("Sound") == 1)
        {
            if (scene.name != "LevelsMenu")
            {
                soundOn.SetActive(true);
                soundOff.SetActive(false);
            }
            audioSource.Play();
        }

        else if (PlayerPrefs.GetInt("Sound") == 0)
        {
            if (scene.name != "LevelsMenu")
            {
                soundOn.SetActive(false);
                soundOff.SetActive(true);
            }
            audioSource.Pause();
        }
    }

    public void turnSoundOff()
    {
        PlayerPrefs.SetInt("Sound", 0);
        soundOn.SetActive(false);
        soundOff.SetActive(true);
        audioSource.Pause();
    }

    public void turnSoundOn()
    {
        PlayerPrefs.SetInt("Sound", 1);
        soundOn.SetActive(true);
        soundOff.SetActive(false);
        audioSource.Play();
    }
}
