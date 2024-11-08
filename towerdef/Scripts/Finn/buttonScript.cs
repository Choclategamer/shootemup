using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class buttonScript : MonoBehaviour
{
    public GameObject mainMenu;
    public GameObject settings;
    public GameObject levelSelect;
    public GameObject Pause;

    GameMaster gm;





    public void nextScene()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);  //dit doet de scene +1
        Debug.Log("play");
    }

    public void QuitGame() //dit quit de hele game
    {
        Debug.Log("quit");
        Application.Quit();
    }
    public void ReturnMenu()  // load scene 0, oftewel de main menu
    {
        SceneManager.LoadScene(0);
    }



    public void ResetScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 0);  //reset de scene
    }

    public void SettingsMenu()
    {
        mainMenu.SetActive(false);
        settings.SetActive(true);
    }
    public void BackToMainMenu()
    {
        levelSelect.SetActive(false);
        settings.SetActive(false);
        mainMenu.SetActive(true);
        
    }

    public void LevelSelection()
    {
        levelSelect.SetActive(true);
        mainMenu.SetActive(false);
    }

    public void QuitPause()
    {
        Pause.SetActive(false);
        gm.pause = false;
    }

    public void Level1()
    {
        SceneManager.LoadScene(1); //laad scene nr 1
    }
    public void Level2()
    {
        SceneManager.LoadScene(2);//laad scene nr 2
    }
    public void Level3()
    {
        SceneManager.LoadScene(3); //laad scene nr 3
    }







}
