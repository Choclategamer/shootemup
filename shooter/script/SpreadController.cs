using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpreadController : MonoBehaviour
{
    public Transform[] firePoints;
 
    public float shotSpeed;
    public float shotCounter, fireRate;
    public GameObject ammoType;

    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
            {
                shotCounter -= Time.deltaTime;
                if (shotCounter <= 0)
                {
                    shotCounter = fireRate;
                    shoot();
                }
            }
            else
            {
                shotCounter = 0;
            }


    }
    void shoot() //Instantiate prefab
    {
        foreach (Transform firePoint in firePoints)
        {
            GameObject shot = Instantiate(ammoType, firePoint.position, firePoint.rotation);
            Rigidbody2D shotRB = shot.GetComponent<Rigidbody2D>();
            shotRB.AddForce(firePoint.up * shotSpeed, ForceMode2D.Impulse);
        }
    }
}
