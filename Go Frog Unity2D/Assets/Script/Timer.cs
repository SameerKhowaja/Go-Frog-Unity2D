using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public Text timeTXT;
    public AudioSource aud;
    float timeToSpawn = 1.5f;
    public int count = 15;
    public frogMove fm;

    void Update()
    {
        timeTXT.text = count.ToString();
        if (Time.time >= timeToSpawn)
        {
            count--;
            timeTXT.text = count.ToString();
            
            timeToSpawn = Time.time + 1.5f;

            if(count == 0)
            {
                fm.enabled = false;
                aud.enabled = true;
                
                Invoke("scene", 1f);
            }
        }
    }

    void scene()
    {
        SceneManager.LoadScene("lvl01");
    }
}
