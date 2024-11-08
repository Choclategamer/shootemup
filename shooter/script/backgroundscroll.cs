using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backgroundscroll : MonoBehaviour
{
    public float ySpeed;
    public int inworld;
    Rigidbody2D rb;

    void Start()
    {
        Destroy(gameObject, inworld);
    }

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        rb.velocity = new Vector2(0, ySpeed * -1);

    }
}
