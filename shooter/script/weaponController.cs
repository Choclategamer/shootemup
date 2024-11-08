using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weaponController : MonoBehaviour
{
    public Transform firePoint;
    public GameObject ammoType;

    public float shotSpeed;
    public float shotCounter, fireRate;
    Vector2 direction;
 
    void Start()
    {
        direction = (transform.localRotation * Vector2.up).normalized;
    }


    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            shotCounter -= Time.deltaTime;
            if (shotCounter <=0)
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
        GameObject shot = Instantiate(ammoType, firePoint.position, firePoint.rotation);
        Rigidbody2D shotRB = shot.GetComponent<Rigidbody2D>();
        shotRB.AddForce(firePoint.up * shotSpeed, ForceMode2D.Impulse);
        Destroy(shot.gameObject, 2f);
    }
}
