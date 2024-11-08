using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

public class GameMaster : MonoBehaviour
{
  

    [Header("pause")]
    public GameObject PauseMenu;
    public bool pause;
    public bool ifPaused;


    [Header("money")]
    public Text moneyText;
    public float money = 500f;
    
    



    //float spawnDelay = 1;



    void Start()
    {
        ifPaused = false;
    }

    void Update()
    {

        moneyText.text = money.ToString(); //money naar de moneytext
       
        if (Input.GetKeyDown(KeyCode.Escape) && ifPaused == false && Time.timeScale == 1)
        {
            ifPaused = true;
            Pause();
        }
        if (Input.GetKeyDown(KeyCode.Escape) && ifPaused == true && Time.timeScale == 0)
        {
            ifPaused = false;
            Resume();
        }



        //spawnDelay -= Time.deltaTime;
        //if (spawnDelay <= 0)
        //{
        //    Instantiate(enemyToSpawn, spawnPoint.transform.position, spawnPoint.transform.rotation);
        //    spawnDelay = 1;
        //}

    }

    public void Pause()
    {
        pause = true;
        if (pause == true && Time.timeScale == 1)
        {
            Time.timeScale = 0.0f; 
            PauseMenu.SetActive(true);
        }
       
           
        
    }
    public void Resume()
    {
        pause = false;
        if (pause == false && Time.timeScale == 0)
        {
            Time.timeScale = 1.0f;
            PauseMenu.SetActive(false);
        }
    }

    

}
