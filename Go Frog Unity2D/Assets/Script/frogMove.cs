using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class frogMove : MonoBehaviour
{
    float xPos, yPos;
    public float speed = 5f;
    float xWidth = 5.7f;
    Vector3 clampedPosition;
    float slowness = 10f;
    public Rigidbody2D rb;
    public AudioSource aud;

    void FixedUpdate()
    {
        float yPos = Input.GetAxis("Vertical") * Time.deltaTime * speed;
        transform.Translate(0f, yPos, 0f);
        clampedPosition = transform.position;
        clampedPosition.y = Mathf.Clamp(clampedPosition.y, -4.23f, 3.12f);
        transform.position = clampedPosition;

        float xPos = Input.GetAxis("Horizontal") * Time.deltaTime * speed;
        transform.Translate(xPos, 0f, 0f);
        clampedPosition = transform.position;
        clampedPosition.x = Mathf.Clamp(clampedPosition.x, -xWidth, xWidth);
        transform.position = clampedPosition;
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Finish")
        {
            StartCoroutine(wait());
        }

        if (collision.collider.tag == "car")
        {
            StartCoroutine(restarter());
            aud.enabled = true;
        }
    }

    IEnumerator restarter()
    {
        Time.timeScale = 1f / slowness;
        Time.fixedDeltaTime = Time.fixedDeltaTime / slowness;
        yield return new WaitForSeconds(1f/slowness);
        Time.timeScale = 1f;
        Time.fixedDeltaTime = Time.fixedDeltaTime * slowness;

        SceneManager.LoadScene("lvl01");
    }

    IEnumerator wait()
    {
        Time.timeScale = 1f / slowness;
        Time.fixedDeltaTime = Time.fixedDeltaTime / slowness;
        yield return new WaitForSeconds(1f / slowness);
        Time.timeScale = 1f;
        Time.fixedDeltaTime = Time.fixedDeltaTime * slowness;

        transform.Translate(0f, -7.31f, 0f);
    }

}
