using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class HomingMissile : MonoBehaviour
{
	public GameObject target;
	public float speed = 5f;
	public float rotateSpeed = 200f;
	public int score;
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

	void OnTriggerEnter2D(Collider2D col)
	{
		if (col.gameObject.tag == "Playerbullet")
		{
			ScoreSystem.scoreValue += score;
			Destroy(gameObject);
		}
		else if (col.gameObject.tag == "Player")
		{
			col.gameObject.GetComponent<spaceship>().Damage();
			Destroy(gameObject);
		}
	}
}