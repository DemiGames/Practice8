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
    private int index = 1;
    private int currentIndex = 0;
    private Transform currentRunner;

    void Start()
    {
        target = runnersArray[index].transform.position;
        currentRunner = runnersArray[currentIndex];
    }

    void Update()
    {
        if (!isRunning) return;
        Move();
        if (TargetIsReached())
            ChangeCurrentRunner();
    }
    private void Move()
    {
        currentRunner.position = Vector3.MoveTowards(currentRunner.position, target, Time.deltaTime * speed);
    }
    private bool TargetIsReached()
    {
        return currentRunner.position == target;
    }
    private void ChangeCurrentRunner()
    {
        currentIndex = index;
        currentRunner = runnersArray[index];
        index = (index + 1) % runnersArray.Length;
        target = runnersArray[index].position;
        Move();
    }
}