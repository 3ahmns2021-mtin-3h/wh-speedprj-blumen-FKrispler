using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blumen : MonoBehaviour
{
    private int spacePress;
    private int kPress;

    public float startTime, stopTime, timer;

    bool istimerrunning;
    // Start is called before the first frame update
    void Start()
    {
        spacePress = 0;
        kPress = 0;
        istimerrunning = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (istimerrunning)
        {
            startTime = Time.time;
        }

        timer = stopTime + (Time.time - startTime);

        // Debug.Log(timer); 

        if (Input.GetKeyUp(KeyCode.Space))
        {
            TimerStart();
            Debug.Log(startTime);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            spacePress++;

            Debug.Log("Space press" + spacePress);
        }

        if (Input.GetKeyDown(KeyCode.K))
        {
            kPress++;
            Debug.Log("K Press" + kPress);
        }

    }

    void TimerStart()
    {
        startTime = Time.time;
    }

    void TimerStop()
    {
        stopTime = Time.time;
    }

    void TimerReset()
    {
        timer = startTime = stopTime = 0.0f;
    }
}
