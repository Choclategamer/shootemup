using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
	public spaceship playerHealth;
	public Slider HPslider;

	public void Start()
	{
		playerHealth = GameObject.FindGameObjectWithTag("Player").GetComponent<spaceship>();
	}
	public void SetMaxHealth(int health)
	{
		HPslider.maxValue = health;
		HPslider.value = health;
	}
	public void SetHealth(int health)
	{
		HPslider.value = health;
	}
}