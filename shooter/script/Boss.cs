using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss : MonoBehaviour
{
	public GameObject target;
	public float speed = 5f;
	public float rotateSpeed = 200f;
	public int score;
	public int damage =1 ;
	private Rigidbody2D rb;

	void Start()
	{
		rb = GetComponent<Rigidbody2D>();
		target = GameObject.Find("Playership");
	}

	void FixedUpdate()
	{
		Vector2 direction = (Vector2)target.transform.position - rb.position;
		direction.Normalize();
		float rotateAmount = Vector3.Cross(direction, transform.up).z;
		rb.angularVelocity = -rotateAmount * rotateSpeed;
		rb.velocity = transform.up * speed;
	}
}
