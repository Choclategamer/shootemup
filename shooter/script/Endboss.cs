using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Endboss : MonoBehaviour
{
    public Enemyship Bossship;

    void Update()
    {
        if (Bossship.health <= 0)
        {
            
            Time.timeScale = 0f;
        }
    }
}
