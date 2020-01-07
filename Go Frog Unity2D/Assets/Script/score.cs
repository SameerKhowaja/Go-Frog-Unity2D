using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    public Text T1, T2;
    public AudioSource aud;
    public Timer tm;
    int points;
    bool check;

    private void Start()
    {
        check = true;
        T2.text = PlayerPrefs.GetInt("highscore", 0).ToString();
        T1.text = "0";
    }

    void Update()
    {
        T1.text = points.ToString();
        if (int.Parse(T1.text) > int.Parse(T2.text))
        {
            PlayerPrefs.SetInt("highscore", points);
            T2.text = points.ToString();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.tag == "Player")
        {
            points += 10;
            if(int.Parse(T1.text) <= 100)
                tm.count = 15; //set Timer to 10 if win
            else
                tm.count = 10;

            if (check == true)
            {
                aud.enabled = true;
                check = false;
            }
            else
            {
                aud.Play();
            }
        }
    }
}
