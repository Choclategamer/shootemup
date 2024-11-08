using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor.SceneManagement;

public class Mainmenu : MonoBehaviour
{
    public GameObject MainUI;
    public GameObject OptiemenuUI;
    public GameObject LevelScreenUI;
    public GameObject InfoLevelScreenUI;
    public GameObject InfoLevelScreenUI_1;
    public GameObject InfoLevelScreenUI_2;
    public GameObject InfoLevelScreenUI_3;
    public GameObject InfoLevelScreenUI_4;
    public GameObject Pausemenu;
    public void playGameLEVEL1()
    {
        EditorSceneManager.LoadScene(2);
    }
    public void playGameLEVEL2()
    {
        EditorSceneManager.LoadScene(3);
    }
    public void playGameLEVEL3()
    {
        EditorSceneManager.LoadScene(4);
    }
    public void StartMainmenu()
    {
        MainUI.SetActive(true);

        OptiemenuUI.SetActive(false);
        LevelScreenUI.SetActive(false);
        InfoLevelScreenUI.SetActive(false);
        InfoLevelScreenUI.SetActive(false);
        InfoLevelScreenUI_1.SetActive(false);
        InfoLevelScreenUI_2.SetActive(false);
        InfoLevelScreenUI_3.SetActive(false);
        InfoLevelScreenUI_4.SetActive(false);

    }
    public void Optiemenumenu()
    { 
        OptiemenuUI.SetActive(true);
        MainUI.SetActive(false);
        LevelScreenUI.SetActive(false);
        InfoLevelScreenUI.SetActive(false); 
    }
    public void LevelScreenUImenu()
    {
        LevelScreenUI.SetActive(true);
        OptiemenuUI.SetActive(false);
        MainUI.SetActive(false);
        InfoLevelScreenUI.SetActive(false);
    }
    public void InfoLevelScreenUImenu()
    {
        InfoLevelScreenUI.SetActive(true);

        InfoLevelScreenUI_1.SetActive(false);
        InfoLevelScreenUI_2.SetActive(false);
        InfoLevelScreenUI_3.SetActive(false);
        InfoLevelScreenUI_4.SetActive(false);

        LevelScreenUI.SetActive(false);
        OptiemenuUI.SetActive(false);
        MainUI.SetActive(false);
    }
    public void InfoLevelScreenUImenu1()
    {
        InfoLevelScreenUI.SetActive(false);
        InfoLevelScreenUI_1.SetActive(true);
        InfoLevelScreenUI_2.SetActive(false);
        InfoLevelScreenUI_3.SetActive(false);
        InfoLevelScreenUI_4.SetActive(false);
    }
    public void InfoLevelScreenUImenu2()
    {
        InfoLevelScreenUI.SetActive(false);
        InfoLevelScreenUI_1.SetActive(false);
        InfoLevelScreenUI_2.SetActive(true);
        InfoLevelScreenUI_3.SetActive(false);
        InfoLevelScreenUI_4.SetActive(false);
    }
    public void InfoLevelScreenUImenu3()
    {
        InfoLevelScreenUI.SetActive(false);
        InfoLevelScreenUI_1.SetActive(false);
        InfoLevelScreenUI_2.SetActive(false);
        InfoLevelScreenUI_3.SetActive(true);
        InfoLevelScreenUI_4.SetActive(false);
    }
    public void InfoLevelScreenUImenu4()
    {
        InfoLevelScreenUI.SetActive(false);
        InfoLevelScreenUI_1.SetActive(false);
        InfoLevelScreenUI_2.SetActive(false);
        InfoLevelScreenUI_3.SetActive(false);
        InfoLevelScreenUI_4.SetActive(true);
    }



    public void Quitgame()
    {
        Application.Quit();
        Debug.Log("Quit");
    }
}
