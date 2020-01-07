using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyCarMove : MonoBehaviour
{
    public int speed;
    float checkRotate;

    private void Start()
    {
        speed = 7;
    }

    void FixedUpdate()
    {
        speed = Random.Range(5, 10); ;

        Vector2 forward = new Vector2(transform.right.x, transform.right.y);
        GetComponent<Rigidbody2D>().MovePosition(GetComponent<Rigidbody2D>().position + forward * Time.fixedDeltaTime * speed);
        /*
        checkRotate = GetComponent<Transform>().transform.rotation.z;
        if (checkRotate == -1f)
        {
            GetComponent<Rigidbody2D>().AddForce(speed *  Vector2.left * Time.fixedDeltaTime, 0f);
        }
        else
        {
            GetComponent<Rigidbody2D>().AddForce(speed *  Vector2.right * Time.fixedDeltaTime, 0f);
        }
        */

        if (transform.position.x <= -8f || transform.position.x >= 8f)
        {
            Destroy(gameObject);
        }
    }

    

}
