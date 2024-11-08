using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleAIScript : MonoBehaviour
{
    [SerializeField] private Transform targetPositionTransform;
    [SerializeField] private string selectableTag = "AI";

    SimpleCarController simpleCarController;

    public MainMenu mm;

    [SerializeField] GameObject MainMenu;

    public float EnemyLaps;

    private void Awake()
    {
        simpleCarController = GetComponent<SimpleCarController>();
        targetPositionTransform = simpleCarController.currentCheckPoint.transform;

        MainMenu = GameObject.FindGameObjectWithTag("MainMenu");

        mm = MainMenu.GetComponent<MainMenu>();
    }

    // Update is called once per frame
    void Update()
    {
    
        Vector3 targetPosition = targetPositionTransform.position;
        float forwards = 0;
        float turn = 0;

        Vector3 directionToTarget = (targetPosition - transform.position);
        float dot = Vector3.Dot(transform.forward, directionToTarget);

        float distance = Vector3.Distance(transform.position, targetPosition);
        float minDistance = 5f;
        GameObject[] EnemyVehicle;

        if (distance > minDistance)
        {
            if (dot > 0)
            {
                forwards = 1;
            }
            else if (dot < 0)
            {
            forwards = -1;
            }
            float angle = Vector3.SignedAngle(transform.forward, directionToTarget, Vector3.up);

            if (angle > 5)
            {
                turn = 1;
            }
            else if (angle < -5)
            {
                turn = -1;
            }
        }
        else
        {
            targetPositionTransform = simpleCarController.NextCheckpoint().transform;
        }
        simpleCarController.ChangeSpeed(forwards);
        simpleCarController.Turn(turn);

        if (EnemyLaps == 4)
        {
            mm.Background.SetActive(true);
            mm.DeathScreen.SetActive(false);
            mm.PlayingGame = false;
            mm.GameFinished = true;
            Time.timeScale = 0f;
            EnemyLaps = 0;
        }
    }
}
