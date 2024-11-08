using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Upgrade : MonoBehaviour
{
    [SerializeField] private string selectableTag = "OccupiedTiles";
    [SerializeField] private Material highlightMaterial;
    [SerializeField] private Material defaultMaterial;

    public GameObject BulletUpgradeButton;
    public GameObject RocketUpgradeButton;
    public GameObject SniperBulletUpgradeButton;


    Bullet bbullet;
    Bullet rbullet;
    Bullet sbullet;

    [SerializeField] GameObject bullet;
    [SerializeField] GameObject rocket;
    [SerializeField] GameObject sniperbullet;

    private Transform _selection;
    public RaycastHit hit;

    bool canUpgrade = false;
    // Start is called before the first frame update

/*    private void Awake()
    {
        bbullet.damage = 5;
        bbullet.speed = 2;

        rbullet.damage = 20;
        rbullet.speed = 1;
        rbullet.explosionRadius = 5;

        sbullet.damage = 10;
        sbullet.speed = 5;
    }*/

    void Start()
    {
        bbullet = bullet.GetComponent<Bullet>();
        rbullet = rocket.GetComponent<Bullet>();
        sbullet = sniperbullet.GetComponent<Bullet>();

        bbullet.damage = 5;
        bbullet.speed = 2;

        rbullet.damage = 20;
        rbullet.speed = 1;
        rbullet.explosionRadius = 5;

        sbullet.damage = 10;
        sbullet.speed = 5;
    }

    // Update is called once per frame
    void Update()
    {
        HoverOverUpgrade();
        TowerSelectUpgrade();
    }

    public void HoverOverUpgrade()
    {
        if (_selection != null)
        {
            var selectionRenderer = _selection.GetComponent<Renderer>();
            selectionRenderer.material = defaultMaterial;
            _selection = null;
        }

        var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            var selection = hit.transform;
            if (selection.CompareTag("BulletTower"))
            {
                var selectionRenderer = selection.GetComponent<Renderer>();
                if (selectionRenderer != null)
                {
                    selectionRenderer.material = highlightMaterial;
                }

                _selection = selection;

            }
            if (selection.CompareTag("RocketTower"))
            {
                var selectionRenderer = selection.GetComponent<Renderer>();
                if (selectionRenderer != null)
                {
                    selectionRenderer.material = highlightMaterial;
                }

                _selection = selection;

            }
            if (selection.CompareTag("SniperTower"))
            {
                var selectionRenderer = selection.GetComponent<Renderer>();
                if (selectionRenderer != null)
                {
                    selectionRenderer.material = highlightMaterial;
                }

                _selection = selection;

            }
        }
    }

    public void TowerSelectUpgrade()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit))
            {

                if (hit.collider.gameObject.tag == "BulletTower" )
                {
                    Vector3 TileInfo = new Vector3(hit.collider.gameObject.transform.position.x, hit.collider.gameObject.transform.position.y, hit.collider.gameObject.transform.position.z);


                    BulletUpgradeButton.SetActive(true);
                    RocketUpgradeButton.SetActive(false);
                    SniperBulletUpgradeButton.SetActive(false);

                }

                if (hit.collider.gameObject.tag == "RocketTower")
                {
                    Vector3 TileInfo = new Vector3(hit.collider.gameObject.transform.position.x, hit.collider.gameObject.transform.position.y, hit.collider.gameObject.transform.position.z);


                    BulletUpgradeButton.SetActive(false);
                    RocketUpgradeButton.SetActive(true);
                    SniperBulletUpgradeButton.SetActive(false);
                }

                if (hit.collider.gameObject.tag == "SniperTower")
                {
                    Vector3 TileInfo = new Vector3(hit.collider.gameObject.transform.position.x, hit.collider.gameObject.transform.position.y, hit.collider.gameObject.transform.position.z);


                    BulletUpgradeButton.SetActive(false);
                    RocketUpgradeButton.SetActive(false);
                    SniperBulletUpgradeButton.SetActive(true);
                }
            }
        }
    }



    public void BulletUpgrade()
    {
        bbullet.damage = 50;
        bbullet.speed = 30;

        if(tag == "BulletTower")
        {
            gameObject.tag = "BulletTower1";
        }
        
    }

    public void RocketUpgrade()
    {
        rbullet.damage = 200;
        rbullet.speed = 200;
        rbullet.explosionRadius = 5000;
    }

    public void SniperBulletUpgrade()
    {
        sbullet.damage = 300;
        sbullet.speed = 500;
    }
}















// Oopgrade(TileInfo);
/*if (towerSelected == true)
{
    hit.collider.gameObject.tag = "OccupiedTiles";
}*/


