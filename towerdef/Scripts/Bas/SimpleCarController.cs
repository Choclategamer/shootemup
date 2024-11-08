using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleCarController : MonoBehaviour
{
    public float maxSpeed = 30;
    public float turnSpeed = 50;
    public float accel = 3f;
    public float speed = 0;
    public GameObject[] checkPointList;
    public GameObject currentCheckPoint;
    public int currentCheckpointID = 0;

    public void ChangeSpeed(float throttle)
    {
        if (throttle != 0)
        {
            speed = speed + accel * throttle * Time.deltaTime;
            speed = Mathf.Clamp(speed, -maxSpeed, maxSpeed);
            Vector3 velocity = Vector3.forward * speed;
            transform.Translate(velocity * Time.deltaTime, Space.Self);
        }
    }

    public void Turn(float direction)
    {
        transform.Rotate(0, direction * turnSpeed * Time.deltaTime, 0);
    }

    public GameObject NextCheckpoint()
    {
        currentCheckpointID++;
        if (currentCheckpointID > checkPointList.Length - 1)
        {
            currentCheckpointID = 0;
        }
        currentCheckPoint = checkPointList[currentCheckpointID];
        return currentCheckPoint;
    }
}
