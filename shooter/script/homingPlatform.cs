using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class homingPlatform : MonoBehaviour
{
    public GameObject player;
    public float speed;
    public GameObject target;

    public void Start()
    {
        target = GameObject.Find("Playership");
    }
    public float rotationModifier;

    Rigidbody2D rb;
    private void FixedUpdate()
    {
        if (player != null)
        {
            Vector3 vectorToTarget = target.transform.position - transform.position;
            float angle = Mathf.Atan2(vectorToTarget.y, vectorToTarget.x) * Mathf.Rad2Deg - rotationModifier;
            Quaternion q = Quaternion.AngleAxis(angle, Vector3.forward);
            transform.rotation = Quaternion.Slerp(transform.rotation, q, Time.deltaTime * speed);
        }

    }
}
