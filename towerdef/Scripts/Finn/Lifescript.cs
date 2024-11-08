using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Lifescript : MonoBehaviour
{

    public float health;
    public Text healtText;

    public GameObject UI;
    public GameObject endscreen;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            health = health - 1;
            
        }

        if (other.gameObject.tag == "Enemy2")
        {
            health = health - 2;

        }

        if (other.gameObject.tag == "Enemy3")
        {
            health = health - 3;

        }
    }
   
    
    
    public void Update()
    {
        healtText.text = health.ToString();
        if(health <= 0)
        {
            health = 0;
        }
        
        if (health == 0)
        {
            UI.SetActive(false);
            endscreen.SetActive(true);
        }
    }

   
}
