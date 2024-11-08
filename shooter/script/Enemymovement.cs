using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemymovement : MonoBehaviour
{
    Rigidbody2D rb;
    [Header("Speed")]
    public float xSpeed;
    public float ySpeed;

    [Header("Wave settings")]
    public bool Waves;
    public float Breedte = 0; // hoe hoog de golven zijn
    public float Lengte = 0; //  hoe groot de golven zijn
    public bool Invert;


    float sinCenterX;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void Start()
    {
        sinCenterX = transform.position.x;
    }
    private void Update()
    {
        rb.velocity = new Vector2(xSpeed, ySpeed * -1);
    }
    private void FixedUpdate()
    {
        if (Waves)
        {
            Vector2 pos = transform.position;

            float sin = Mathf.Sin(pos.y * Lengte) * Breedte;

            if (Invert)
            {
                sin *= -1;
            }
            pos.x = sinCenterX + sin;
            transform.position = pos;

        }

    }
}
