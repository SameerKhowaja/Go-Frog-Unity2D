using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class modes : MonoBehaviour
{
    public spawnCars scrs;
    public enablingFrogMove efm;
    public Text start, highscore;
    public AudioSource aud;

    private void Start()
    {
        highscore.text = PlayerPrefs.GetInt("highscore", 0).ToString();
    }

    void Update()
    {
        if (Input.GetKey("escape"))
        {
            Application.Quit();
        }

        if (Input.GetKey("l"))
        {
            SceneManager.LoadScene("lvl01");
        }

        if (Input.GetKey("s"))
        {
            scrs.enabled = efm.enabled = true;
            start.enabled = false;
            aud.enabled = true;
        }

        if (Input.GetKey("r"))
        {
            PlayerPrefs.DeleteKey("highscore");
            highscore.text = PlayerPrefs.GetInt("highscore", 0).ToString();
        }

    }
}
