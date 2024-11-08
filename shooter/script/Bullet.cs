using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    Rigidbody2D rb;
    public int bulletRotation;
    public float bulletDamage;
    public int destroyTime;
    public bool Playerbullet;
    
    
    private void Awake()
    {
        rb= GetComponent<Rigidbody2D>();
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        transform.rotation = Quaternion.Euler(Vector3.forward * bulletRotation);
        if (Playerbullet == true)
        {
            if (col.gameObject.tag == "Enemy")
            {
                col.gameObject.GetComponent<Enemyship>().damageEnemy(bulletDamage);
                Destroy(gameObject);
            }
        }
        else if (Playerbullet == false)
        {
            if (col.gameObject.tag == "Player")
            {
                col.gameObject.GetComponent<spaceship>().Damage();
                Destroy(gameObject);
            }
        }
    }
}
