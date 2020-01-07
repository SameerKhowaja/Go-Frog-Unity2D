using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enablingFrogMove : MonoBehaviour
{
    public frogMove fm;
    public Timer tm;
    
    void Update()
    {
        StartCoroutine(wait());
    }

    IEnumerator wait()
    {
        yield return new WaitForSeconds(1f);
        fm.enabled = true;
        tm.enabled = true;
        this.enabled = false;
    }
}
