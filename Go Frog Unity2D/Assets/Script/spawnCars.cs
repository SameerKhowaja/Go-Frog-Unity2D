using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnCars : MonoBehaviour
{
    public Transform[] car;
    int ranRange;
    public GameObject pre1, pre2, pre3;
    float timeToSpawn = 2f;
    float wavesRandom;

    void FixedUpdate()
    {
        if (Time.time >= timeToSpawn)
        {
            CarSpawn();
            wavesRandom = Random.Range(0.2f, 1.5f);
            timeToSpawn = Time.time + wavesRandom;
        }
    }

    void CarSpawn()
    {
        for (int i = 0; i < car.Length; i++)
        {
            ranRange = Random.Range(1, 4);
            if (i==1 || i==3) //for points 1 and 3
            {
                if (ranRange == 1)
                {
                    Instantiate(pre1, car[i].position, Quaternion.Euler(0f,0f,180f));
                }
                else if (ranRange == 2)
                {
                    Instantiate(pre2, car[i].position, Quaternion.Euler(0f, 0f, 180f));
                }
                else
                {
                    Instantiate(pre3, car[i].position, Quaternion.Euler(0f, 0f, 180f));
                }
            }
            else //for points 0 and 2
            {
                if (ranRange == 1)
                {
                    Instantiate(pre1, car[i].position, Quaternion.identity);
                }
                else if (ranRange == 2)
                {
                    Instantiate(pre2, car[i].position, Quaternion.identity);
                }
                else
                {
                    Instantiate(pre3, car[i].position, Quaternion.identity);
                }
            }
        }

    }


}
