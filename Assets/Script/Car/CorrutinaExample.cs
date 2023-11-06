using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CorrutinaExample : MonoBehaviour
{
    public bool isRunning;

    private void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            isRunning = true;
            StartCoroutine(Counting());
        }

        if (Input.GetButtonUp("Jump"))
        {
            isRunning = false;
        }
    }


    IEnumerator Counting()
    {
        int count = 0;
        while (isRunning)
        {
            print(count);
            yield return new WaitForSeconds(1);
            count++;
        }
        yield break;
    }
    
}
