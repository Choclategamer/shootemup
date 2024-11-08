using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemyship : MonoBehaviour
{
    Rigidbody2D rb;

    [Header("Animation")]
    private Animator anim;
    public int ShipNumber;

    [Header("HP and Score")]
    public float health;
    public int score;
    public int Deathtime = 1;
    public bool Boss =false;

    [Header("FirePower")]
    public bool canshoot;
    public float firerate;
    public float shotSpeed;
    
    [Header("Ammo type & Firepoint")]
    public Transform firePoint;
    public GameObject ammoType;

    [Header("Loot")]
    public bool Dropper = false;
    public GameObject DropItem;
    private bool itemcounter = true;


    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    void Start()
    {
        if (!canshoot) return;
        firerate = firerate + (Random.Range(firerate / -2, firerate / 2));
            InvokeRepeating("shoot", firerate, firerate);
    }
    private void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag=="Player")
        {
            coll.gameObject.GetComponent<spaceship>().Damage();
            Die();
        }
    }
    void Die()
    {  
        if (ShipNumber == 1)
        {
            anim.Play("Death");
        }
       if (ShipNumber == 2)
        {
            anim.Play("Death2");
        }
        if (ShipNumber == 3)
        {
            anim.Play("Death3");
        }
        if (ShipNumber == 4)
        {
            anim.Play("Death4");
        }
        if (ShipNumber == 5)
        {
            anim.Play("Death5");
        }
        if (ShipNumber == 6)
        {
            anim.Play("Death6");
        }

        ScoreSystem.scoreValue += score;

        Destroy(gameObject, Deathtime);

        if (Dropper || Boss)
        {
            while (itemcounter == true)
            {
                itemcounter = false;
                Instantiate(DropItem, transform.position, Quaternion.identity);
            }
        }

    }
    public void damageEnemy( float bulletDamage)
    {
        health -= bulletDamage;
        if (health <= 0)
        {
            Die(); 
        }
    }

    void shoot()
    {
        GameObject shot = Instantiate(ammoType, firePoint.position, firePoint.rotation);
        Rigidbody2D shotRB = shot.GetComponent<Rigidbody2D>();
        shotRB.AddForce(firePoint.up * shotSpeed, ForceMode2D.Impulse);
    }
}
