using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleOverTime : MonoBehaviour
{
    public float scaleSpd;
    public float minScale, maxScale;

    Vector2 scale;
    void Start()
    {
        scale = transform.localScale;
    }


    void Update()
    {
        scale = new Vector2(Mathf.Clamp(scale.x += scaleSpd * Time.deltaTime, minScale, maxScale), scale.y);
        scale = new Vector2(scale.x, Mathf.Clamp(scale.y += scaleSpd * Time.deltaTime, minScale, maxScale));

        transform.localScale = scale;
    }
}
