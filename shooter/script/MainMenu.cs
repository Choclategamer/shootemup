using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject Menu;
    public GameObject Options;
    public GameObject LevelMenu;
    public GameObject Information;
    void Start()
    {
        Information.SetActive(false);
        Menu.SetActive(true);
        Options.SetActive(false);
        LevelMenu.SetActive(false);
    }

    public void Main()
    {
        Menu.SetActive(true);
        Information.SetActive(false);
        LevelMenu.SetActive(false);
        Options.SetActive(false);
    }
    public void LevelSelect()
    {
        Information.SetActive(false);
        Options.SetActive(false);
        Menu.SetActive(false);
        LevelMenu.SetActive(true);
    }
    public void StartButton()
    {
        SceneManager.LoadScene(2);
        LevelMenu.SetActive(true);
        Menu.SetActive(false);
    }
    public void OptionButton()
    {
        Information.SetActive(false);
        Options.SetActive(true);
        Menu.SetActive(false);
        LevelMenu.SetActive(false);
    }
    public void level1()
    {
        SceneManager.LoadScene(1);
    }
    public void level2()
    {
        SceneManager.LoadScene(2);
    }
    public void QuitApplication()
    {
        Debug.Log("Quitting");
        Application.Quit();
    }
}

