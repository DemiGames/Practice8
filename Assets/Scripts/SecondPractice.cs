using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondPractice : MonoBehaviour
{
    public float speed;
    public Transform[] runnersArray;
    private Vector3 target;
    private bool isRunning = true;
    private int value = 0;

    void Start()
    {
        target = runnersArray[value].transform.position;
    }

    void Update()
    {
        if (isRunning)
        {
            runnersArray[value].transform.position = Vector3.MoveTowards(runnersArray[value].transform.position, target, Time.deltaTime * speed);
            MoveToPosition();
        }
    }
    private void MoveToPosition()
    {
        if (runnersArray[value].transform.position == target)
        {
            value++;
            target = runnersArray[value].transform.position;
            runnersArray[value].LookAt(target);
            Debug.Log(value);
        }
    }
}
