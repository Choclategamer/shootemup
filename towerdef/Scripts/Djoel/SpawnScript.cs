using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpawnScript : MonoBehaviour
{

    [SerializeField] public string selectableTag = "Tiles";

    public GameObject towerToSpawn;
    public GameObject towerToSpawn1;
    public GameObject towerToSpawn2;

    public int spawnTower = 0;
    public int maxTowers = 1;
    public int currentTowers = 0;
    public bool towerSelected = false;


    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        OnMouseClick();
    }

    public void SelectTower(int selectTower = 0)
    {

        switch (selectTower)
        {

            case 1:
                spawnTower = 1;
                Debug.Log("Selected tower 1");
                break;
            case 2:
                spawnTower = 2;
                Debug.Log("Selected tower 2");
                break;
            case 3:
                spawnTower = 3;
                Debug.Log("Selected tower 3");
                break;

            default:
                spawnTower = 0;
                Debug.Log("Nothing selected");

                return;
        }

    }

    public void SpawnTower(Vector3 currentPosTile)
    {
        
                switch (spawnTower)
                {
                    case 1:
                        Instantiate(towerToSpawn, new Vector3(currentPosTile.x, 3.25f, currentPosTile.z), transform.rotation);
                        towerSelected = true;
                        break;
                    case 2:
                        Instantiate(towerToSpawn1, new Vector3(currentPosTile.x, 3.25f, currentPosTile.z), transform.rotation);
                        towerSelected = true;
                        break;
                    case 3:
                        Instantiate(towerToSpawn2, new Vector3(currentPosTile.x, 3.25f, currentPosTile.z), transform.rotation);
                        towerSelected = true;
                        break;

                    default:
                        Debug.Log("No tower selected");
                        towerSelected = false;
                        return;
                }
    }


    private void OnMouseClick()
    {

        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit))
            {

                if (hit.collider.gameObject.tag == selectableTag && currentTowers < maxTowers)
                {
                    Vector3 TileInfo = new Vector3(hit.collider.gameObject.transform.position.x, hit.collider.gameObject.transform.position.y, hit.collider.gameObject.transform.position.z);
                   
                    SpawnTower(TileInfo);
                    if(towerSelected == true && spawnTower ==  1)
                    { 
                    hit.collider.gameObject.tag = "BulletTower"; 
                    }

                    if (towerSelected == true && spawnTower == 2)
                    {
                        hit.collider.gameObject.tag = "RocketTower";
                    }

                    if (towerSelected == true && spawnTower == 3)
                    {
                        hit.collider.gameObject.tag = "SniperTower";
                    }
                }
            }
        }
    }
}