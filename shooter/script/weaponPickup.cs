using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weaponPickup : MonoBehaviour
{

    public int typeAmmo;
    public GameObject weapontoGive;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            other.gameObject.GetComponent<WeaponSwap>().UpdateWeapon(weapontoGive);
            Destroy(GameObject.FindGameObjectWithTag("Weapon"));
            Destroy(gameObject);
        }

    }
}
