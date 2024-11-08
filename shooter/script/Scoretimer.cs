using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Scoretimer : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public float scoreAmount;
    public float pointIncreasedPerSecond;
    
    void Start()
    {
        scoreText = GetComponent<TextMeshProUGUI>();
        scoreAmount = 0f;
        pointIncreasedPerSecond = 1f;

    }

    void Update()
    {
        scoreText.text = (int)scoreAmount + " ";
        scoreAmount += pointIncreasedPerSecond * Time.deltaTime;
    }
}
