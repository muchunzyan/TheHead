using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class getCoin : MonoBehaviour
{
    public AudioSource audioSource;
    public GameObject colorsGO;
    public GameObject WinPanel;
    public GameObject PillsText0, PillsText1, PillsText2, PillsText3, PillsText4, PillsText5, PillsText6;
    public GameObject HitsText0, HitsText1, HitsText2, HitsText3;
    public GameObject head_0, head_1, head_2, head_3, head_4, head_5;
    public GameObject btnPause, btnLeft, btnRight, btnUp, btnMap;
    public Image colors;
    public float timeLeft = 0;
    public int tablets = 0, hits = 0;

    void Update()
    {
        timeLeft -= Time.deltaTime;
        if (timeLeft < 0)
        {
            colorsGO.SetActive(false);
        }

        ChangeColor();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Tablet")
        {
            Destroy(other.gameObject);
            colorsGO.SetActive(true);
            timeLeft = 4;
            tablets++;
            setTablets();
        }

        if (other.tag == "target")
        {
            hits++;
            setHits();
            other.gameObject.SetActive(false);
        }
    }

    public void ChangeColor()
    {
        if (timeLeft > 3.5 && timeLeft < 4)
        {
            colors.GetComponent<Image>().color = new Color32(0, 0, 255, 150);
        }

        if (timeLeft > 3 && timeLeft < 3.5)
        {
            colors.GetComponent<Image>().color = new Color32(255, 255, 0, 150);
        }

        if (timeLeft > 2.5 && timeLeft < 3)
        {
            colors.GetComponent<Image>().color = new Color32(0, 255, 0, 150);
        }

        if (timeLeft > 2 && timeLeft < 2.5)
        {
            colors.GetComponent<Image>().color = new Color32(255, 0, 0, 150);
        }

        if (timeLeft > 1.5 && timeLeft < 2)
        {
            colors.GetComponent<Image>().color = new Color32(0, 0, 255, 150);
        }

        if (timeLeft > 1 && timeLeft < 1.5)
        {
            colors.GetComponent<Image>().color = new Color32(255, 255, 0, 150);
        }

        if (timeLeft > 0.5 && timeLeft < 1)
        {
            colors.GetComponent<Image>().color = new Color32(0, 255, 0, 150);
        }

        if (timeLeft > 0 && timeLeft < 0.5)
        {
            colors.GetComponent<Image>().color = new Color32(255, 0, 0, 150);
        }
    }

    public void setTablets()
    {
        if(tablets == 1)
        {
            PillsText0.SetActive(false);
            PillsText1.SetActive(true);
            PillsText2.SetActive(false);
            PillsText3.SetActive(false);
            PillsText4.SetActive(false);
            PillsText5.SetActive(false);
            PillsText6.SetActive(false);

            head_0.SetActive(false);
            head_1.SetActive(true);
            head_2.SetActive(false);
            head_3.SetActive(false);
            head_4.SetActive(false);
            head_5.SetActive(false);
        }

        else if (tablets == 2)
        {
            PillsText0.SetActive(false);
            PillsText1.SetActive(false);
            PillsText2.SetActive(true);
            PillsText3.SetActive(false);
            PillsText4.SetActive(false);
            PillsText5.SetActive(false);
            PillsText6.SetActive(false);

            head_0.SetActive(false);
            head_1.SetActive(false);
            head_2.SetActive(true);
            head_3.SetActive(false);
            head_4.SetActive(false);
            head_5.SetActive(false);
        }

        else if (tablets == 3)
        {
            PillsText0.SetActive(false);
            PillsText1.SetActive(false);
            PillsText2.SetActive(false);
            PillsText3.SetActive(true);
            PillsText4.SetActive(false);
            PillsText5.SetActive(false);
            PillsText6.SetActive(false);

            head_0.SetActive(false);
            head_1.SetActive(false);
            head_2.SetActive(false);
            head_3.SetActive(true);
            head_4.SetActive(false);
            head_5.SetActive(false);
        }

        else if (tablets == 4)
        {
            PillsText0.SetActive(false);
            PillsText1.SetActive(false);
            PillsText2.SetActive(false);
            PillsText3.SetActive(false);
            PillsText4.SetActive(true);
            PillsText5.SetActive(false);
            PillsText6.SetActive(false);

            head_0.SetActive(false);
            head_1.SetActive(false);
            head_2.SetActive(false);
            head_3.SetActive(false);
            head_4.SetActive(true);
            head_5.SetActive(false);
        }

        else if (tablets == 5)
        {
            PillsText0.SetActive(false);
            PillsText1.SetActive(false);
            PillsText2.SetActive(false);
            PillsText3.SetActive(false);
            PillsText4.SetActive(false);
            PillsText5.SetActive(true);
            PillsText6.SetActive(false);

            head_0.SetActive(false);
            head_1.SetActive(false);
            head_2.SetActive(false);
            head_3.SetActive(false);
            head_4.SetActive(false);
            head_5.SetActive(true);
        }

        else if (tablets == 6)
        {
            PillsText0.SetActive(false);
            PillsText1.SetActive(false);
            PillsText2.SetActive(false);
            PillsText3.SetActive(false);
            PillsText4.SetActive(false);
            PillsText5.SetActive(false);
            PillsText6.SetActive(true);

            GameWin();
        }
    }

    public void setHits()
    {
        if (hits == 1)
        {
            HitsText0.SetActive(false);
            HitsText1.SetActive(true);
            HitsText2.SetActive(false);
            HitsText3.SetActive(false);

            head_0.SetActive(false);
            head_1.SetActive(true);
        }

        else if (hits == 2)
        {
            HitsText0.SetActive(false);
            HitsText1.SetActive(false);
            HitsText2.SetActive(true);
            HitsText3.SetActive(false);

            head_1.SetActive(false);
            head_3.SetActive(true);
        }

        else if (hits == 3)
        {
            HitsText0.SetActive(false);
            HitsText1.SetActive(false);
            HitsText2.SetActive(false);
            HitsText3.SetActive(true);

            BossWin();
        }
    }

    public void GameWin()
    {
        Time.timeScale = 0;
        btnPause.SetActive(false);
        btnLeft.SetActive(false);
        btnRight.SetActive(false);
        btnUp.SetActive(false);
        btnMap.SetActive(false);
        WinPanel.SetActive(true);
        Scene scene = SceneManager.GetActiveScene();
        audioSource.Pause();

        if (scene.name == "Level1")
            PlayerPrefs.SetInt("Level1", 1);

        if (scene.name == "Level2")
            PlayerPrefs.SetInt("Level2", 1);

        if (scene.name == "Level3")
            PlayerPrefs.SetInt("Level3", 1);

        if (scene.name == "Level4")
            PlayerPrefs.SetInt("Level4", 1);

        if (scene.name == "Level5")
            PlayerPrefs.SetInt("Level5", 1);

        if (scene.name == "Level6")
            PlayerPrefs.SetInt("Level6", 1);

        if (scene.name == "Level7")
            PlayerPrefs.SetInt("Level7", 1);

        if (scene.name == "Level8")
            PlayerPrefs.SetInt("Level8", 1);

        if (scene.name == "Level9")
            PlayerPrefs.SetInt("Level9", 1);

        if (scene.name == "Level10")
        {
            PlayerPrefs.SetInt("Level10", 1);
            PlayerPrefs.SetInt("YouDidIt", 1);
        }
    }

    public void BossWin()
    {
        Time.timeScale = 0;
        audioSource.Pause();
        
        PlayerPrefs.SetInt("Level10", 1);
        PlayerPrefs.SetInt("YouDidIt", 1);
        SceneManager.LoadScene("Ending");
    }
}
