using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class ScoreSystem : MonoBehaviour
{
    public TextMeshProUGUI scoreText;

    public static int scoreValue;

    void Start()
    {
        scoreText = GetComponent<TextMeshProUGUI>();
        scoreText.text = "";
    }

    void Update()
    {
        scoreText.text = "" + scoreValue;
    }
}