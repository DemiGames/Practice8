using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstPractice : MonoBehaviour
{
    public float speed;
    public Transform[] pointsArray;
    private Vector3 target;
    private bool isRunning = true;
    private int value = 0;

    void Start()
    {
        target = pointsArray[0].position;
    }

    void Update()
    {
        if (isRunning)
        {
            transform.position = Vector3.MoveTowards(transform.position, target, Time.deltaTime * speed);
            MoveToPosition();
        }
    }
    private void MoveToPosition()
    {
        if (transform.position == target)
        {
            value++;
            target = pointsArray[value].position;
        }
        if (target == pointsArray[pointsArray.Length - 1].position)
        {
            Array.Reverse(pointsArray);
            value = 0;
        }
    }
}

