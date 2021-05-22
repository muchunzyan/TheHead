using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class start_boss : MonoBehaviour
{
    public bool stage1 = false, stage2 = false, stage3 = false, stageWait = false;
    public bool fall = true, throw_s = false;
    public bool activate_platform;
    public GameObject player;
    public GameObject platform_up_down;
    public GameObject die_ground_start;
    public GameObject cop1, cop2, cop3;
    public GameObject[] sky_falls = new GameObject[6];
    public GameObject[] sticks = new GameObject[14];
    public GameObject[] sticks2 = new GameObject[14];
    public GameObject[] sticks3 = new GameObject[14];
    public GameObject saw_roll;
    public GameObject protection, prot_on_off;
    public GameObject target;
    public float timer_1 = 0, timer_2 = 0, timer_3 = 0, timer_wait = 0;
    public float i_timer2 = 0, i_timer3 = 0;
    public Collider2D start_collider;

    private void Start()
    {
        start_collider = GetComponent<Collider2D>();
    }

    void Update()
    {
        if (stage1)
        {
            timer_1 += Time.deltaTime;
            Stage1();
        }

        if (stage2)
        {
            i_timer2 += 2 * Time.deltaTime;
            timer_2 = Mathf.Round(i_timer2);
            Stage2();
        }

        if (stage3)
        {
            i_timer3 += Time.deltaTime;
            timer_3 = Mathf.Round(i_timer3);
            Stage3();
        }

        if (stageWait)
        {
            timer_wait += Time.deltaTime;
            StageWait();
        }

        if (activate_platform == true)
        {
            if (platform_up_down.transform.position.x > 40)
            {
                platform_up_down.GetComponent<Rigidbody2D>().velocity = new Vector2(-30, platform_up_down.GetComponent<Rigidbody2D>().velocity.y);
            }
            else
            {
                platform_up_down.SetActive(false);
                platform_up_down.transform.position = new Vector2(66.98027f, platform_up_down.transform.position.y);
                activate_platform = false;
            }
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            BossSterted();
            Destroy(start_collider);
        }
    }

    void BossSterted()
    {
        die_ground_start.SetActive(true);

        stage1 = true;
    }

    void Stage1()
    {
        if (timer_1 > 0 && timer_1 < 1)
            sticks[0].SetActive(true);
        else if (timer_1 > 1 && timer_1 < 2)
            sticks[1].SetActive(true);
        else if (timer_1 > 2 && timer_1 < 3)
             sticks[2].SetActive(true);
        else if (timer_1 > 3 && timer_1 < 4)
             sticks[3].SetActive(true);
        else if (timer_1 > 4 && timer_1 < 5)
             sticks[4].SetActive(true);
        else if (timer_1 > 5 && timer_1 < 6)
             sticks[5].SetActive(true);
        else if (timer_1 > 6 && timer_1 < 7)
             sticks[6].SetActive(true);
        else if (timer_1 > 7 && timer_1 < 8)
             sticks[7].SetActive(true);
        else if (timer_1 > 8 && timer_1 < 9)
             sticks[8].SetActive(true);
        else if (timer_1 > 9 && timer_1 < 10)
             sticks[9].SetActive(true);
        else if (timer_1 > 10 && timer_1 < 11)
             sticks[10].SetActive(true);
        else if (timer_1 > 11 && timer_1 < 12)
             sticks[11].SetActive(true);
        else if (timer_1 > 12 && timer_1 < 13)
             sticks[12].SetActive(true);
        else if (timer_1 > 13 && timer_1 < 14)
             sticks[13].SetActive(true);
        
        if (timer_1 - 3 > 0 && timer_1 - 3 < 1)
            sticks2[0].SetActive(true);
        else if (timer_1 - 3 > 1 && timer_1 - 3 < 2)
            sticks2[1].SetActive(true);
        else if (timer_1 - 3 > 2 && timer_1 - 3 < 3)
            sticks2[2].SetActive(true);
        else if (timer_1 - 3 > 3 && timer_1 - 3 < 4)
            sticks2[3].SetActive(true);
        else if (timer_1 - 3 > 4 && timer_1 - 3 < 5)
            sticks2[4].SetActive(true);
        else if (timer_1 - 3 > 5 && timer_1 - 3 < 6)
            sticks2[5].SetActive(true);
        else if (timer_1 - 3 > 6 && timer_1 - 3 < 7)
            sticks2[6].SetActive(true);
        else if (timer_1 - 3 > 7 && timer_1 - 3 < 8)
            sticks2[7].SetActive(true);
        else if (timer_1 - 3 > 8 && timer_1 - 3 < 9)
            sticks2[8].SetActive(true);
        else if (timer_1 - 3 > 9 && timer_1 - 3 < 10)
            sticks2[9].SetActive(true);
        else if (timer_1 - 3 > 10 && timer_1 - 3 < 11)
            sticks2[10].SetActive(true);
        else if (timer_1 - 3 > 11 && timer_1 - 3 < 12)
            sticks2[11].SetActive(true);
        else if (timer_1 - 3 > 12 && timer_1 - 3 < 13)
            sticks2[12].SetActive(true);
        else if (timer_1 - 3 > 13 && timer_1 - 3 < 14)
            sticks2[13].SetActive(true);

        if (timer_1 - 6 > 0 && timer_1 - 6 < 1)
            sticks3[0].SetActive(true);
        else if (timer_1 - 6 > 1 && timer_1 - 6 < 2)
            sticks3[1].SetActive(true);
        else if (timer_1 - 6 > 2 && timer_1 - 6 < 3)
            sticks3[2].SetActive(true);
        else if (timer_1 - 6 > 3 && timer_1 - 6 < 4)
            sticks3[3].SetActive(true);
        else if (timer_1 - 6 > 4 && timer_1 - 6 < 5)
            sticks3[4].SetActive(true);
        else if (timer_1 - 6 > 5 && timer_1 - 6 < 6)
            sticks3[5].SetActive(true);
        else if (timer_1 - 6 > 6 && timer_1 - 6 < 7)
            sticks3[6].SetActive(true);
        else if (timer_1 - 6 > 7 && timer_1 - 6 < 8)
            sticks3[7].SetActive(true);
        else if (timer_1 - 6 > 8 && timer_1 - 6 < 9)
            sticks3[8].SetActive(true);
        else if (timer_1 - 6 > 9 && timer_1 - 6 < 10)
            sticks3[9].SetActive(true);
        else if (timer_1 - 6 > 10 && timer_1 - 6 < 11)
            sticks3[10].SetActive(true);
        else if (timer_1 - 6 > 11 && timer_1 - 6 < 12)
            sticks3[11].SetActive(true);
        else if (timer_1 - 6 > 12 && timer_1 - 6 < 13)
            sticks3[12].SetActive(true);
        else if (timer_1 - 6 > 13 && timer_1 - 6 < 14)
            sticks3[13].SetActive(true);


        if (timer_1 - 1 > 0 && timer_1 - 1 < 1)
            sticks[0].SetActive(false);
        else if (timer_1 - 1 > 1 && timer_1 - 1 < 2)
            sticks[1].SetActive(false);
        else if (timer_1 - 1 > 2 && timer_1 - 1 < 3)
            sticks[2].SetActive(false);
        else if (timer_1 - 1 > 3 && timer_1 - 1 < 4)
            sticks[3].SetActive(false);
        else if (timer_1 - 1 > 4 && timer_1 - 1 < 5)
            sticks[4].SetActive(false);
        else if (timer_1 - 1 > 5 && timer_1 - 1 < 6)
            sticks[5].SetActive(false);
        else if (timer_1 - 1 > 6 && timer_1 - 1 < 7)
            sticks[6].SetActive(false);
        else if (timer_1 - 1 > 7 && timer_1 - 1 < 8)
            sticks[7].SetActive(false);
        else if (timer_1 - 1 > 8 && timer_1 - 1 < 9)
            sticks[8].SetActive(false);
        else if (timer_1 - 1 > 9 && timer_1 - 1 < 10)
            sticks[9].SetActive(false);
        else if (timer_1 - 1 > 10 && timer_1 - 1 < 11)
            sticks[10].SetActive(false);
        else if (timer_1 - 1 > 11 && timer_1 - 1 < 12)
            sticks[11].SetActive(false);
        else if (timer_1 - 1 > 12 && timer_1 - 1 < 13)
            sticks[12].SetActive(false);
        else if (timer_1 - 1 > 13 && timer_1 - 1 < 14)
            sticks[13].SetActive(false);
        
        if (timer_1 - 4 > 0 && timer_1 - 4 < 1)
            sticks2[0].SetActive(false);
        else if (timer_1 - 4 > 1 && timer_1 - 4 < 2)
            sticks2[1].SetActive(false);
        else if (timer_1 - 4 > 2 && timer_1 - 4 < 3)
            sticks2[2].SetActive(false);
        else if (timer_1 - 4 > 3 && timer_1 - 4 < 4)
            sticks2[3].SetActive(false);
        else if (timer_1 - 4 > 4 && timer_1 - 4 < 5)
            sticks2[4].SetActive(false);
        else if (timer_1 - 4 > 5 && timer_1 - 4 < 6)
            sticks2[5].SetActive(false);
        else if (timer_1 - 4 > 6 && timer_1 - 4 < 7)
            sticks2[6].SetActive(false);
        else if (timer_1 - 4 > 7 && timer_1 - 4 < 8)
            sticks2[7].SetActive(false);
        else if (timer_1 - 4 > 8 && timer_1 - 4 < 9)
            sticks2[8].SetActive(false);
        else if (timer_1 - 4 > 9 && timer_1 - 4 < 10)
            sticks2[9].SetActive(false);
        else if (timer_1 - 4 > 10 && timer_1 - 4 < 11)
            sticks2[10].SetActive(false);
        else if (timer_1 - 4 > 11 && timer_1 - 4 < 12)
            sticks2[11].SetActive(false);
        else if (timer_1 - 4 > 12 && timer_1 - 4 < 13)
            sticks2[12].SetActive(false);
        else if (timer_1 - 4 > 13 && timer_1 - 4 < 14)
            sticks2[13].SetActive(false);

        if (timer_1 - 7 > 0 && timer_1 - 7 < 1)
            sticks3[0].SetActive(false);
        else if (timer_1 - 7 > 1 && timer_1 - 7 < 2)
            sticks3[1].SetActive(false);
        else if (timer_1 - 7 > 2 && timer_1 - 7 < 3)
            sticks3[2].SetActive(false);
        else if (timer_1 - 7 > 3 && timer_1 - 7 < 4)
            sticks3[3].SetActive(false);
        else if (timer_1 - 7 > 4 && timer_1 - 7 < 5)
            sticks3[4].SetActive(false);
        else if (timer_1 - 7 > 5 && timer_1 - 7 < 6)
            sticks3[5].SetActive(false);
        else if (timer_1 - 7 > 6 && timer_1 - 7 < 7)
            sticks3[6].SetActive(false);
        else if (timer_1 - 7 > 7 && timer_1 - 7 < 8)
            sticks3[7].SetActive(false);
        else if (timer_1 - 7 > 8 && timer_1 - 7 < 9)
            sticks3[8].SetActive(false);
        else if (timer_1 - 7 > 9 && timer_1 - 7 < 10)
            sticks3[9].SetActive(false);
        else if (timer_1 - 7 > 10 && timer_1 - 7 < 11)
            sticks3[10].SetActive(false);
        else if (timer_1 - 7 > 11 && timer_1 - 7 < 12)
            sticks3[11].SetActive(false);
        else if (timer_1 - 7 > 12 && timer_1 - 7 < 13)
            sticks3[12].SetActive(false);
        else if (timer_1 - 7 > 13 && timer_1 - 7 < 14)
        {
            sticks3[13].SetActive(false);
            timer_1 = 0;
            stage1 = false;
            stage2 = true;
            cop1.SetActive(false);
            cop2.SetActive(true);
        }
    }

    public void Stage2()
    {
        if (timer_2 % 3 == 0 && fall)
        {
            int n = Random.Range(0, 6);
            Instantiate(sky_falls[n]);
            fall = false;
        }

        if (timer_2 % 3 == 1)
        {
            fall = true;
        }

        if (timer_2 == 15)
        {
            i_timer2 = 0;
            timer_2 = 0;
            stage2 = false;
            stage3 = true;
            cop2.SetActive(false);
            cop3.SetActive(true);
        }
    }

    public void Stage3()
    {

        if (timer_3 % 3 == 0 && throw_s)
        {
            prot_on_off.SetActive(false);
            GameObject clone;
            clone = Instantiate(saw_roll);
            int m = Random.Range(8, 11);
            clone.GetComponent<Rigidbody2D>().velocity = new Vector2(-m, 0);

            throw_s = false;
        }

        if (timer_3 % 3 == 1)
        {
            prot_on_off.SetActive(true);
            throw_s = true;
        }

        if (timer_3 == 15)
        {
            i_timer3 = 0;
            timer_3 = 0;
            protection.SetActive(false);
            target.SetActive(true);
            stage3 = false;
            stageWait = true;
        }
    }

    public void StageWait()
    {
        if (timer_wait > 8 && timer_wait < 8.5f)
        {
            platform_up_down.SetActive(true);
            activate_platform = true;
        }

        if (timer_wait > 10)
        {
            timer_wait = 0;
            stageWait = false;
            prot_on_off.SetActive(true);
            protection.SetActive(true);
            target.SetActive(false);
            stage1 = true;
            cop3.SetActive(false);
            cop1.SetActive(true);
        }
    }
}
