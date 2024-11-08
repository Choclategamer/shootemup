using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject Deahscreen;
    public GameObject Gameplayscreen;
    public GameObject winscreen;
    public GameObject Pausescreen;

    public void Awake()
    {
        Gameplayscreen.SetActive(true);

        winscreen.SetActive(false);
        Pausescreen.SetActive(false);
        Deahscreen.SetActive(false);
    }
    public void AGameplay()
    {
        Time.timeScale = 1f;
        Gameplayscreen.SetActive(true);

        Pausescreen.SetActive(false);
        winscreen.SetActive(false);
        Deahscreen.SetActive(false);

        
    }
    public void AGameOver()
    {
        Time.timeScale = 0f;
        Deahscreen.SetActive(true);

        winscreen.SetActive(false);
        Pausescreen.SetActive(false);
        Gameplayscreen.SetActive(false);
    }
    public void AWinscreen()
    {
        
        winscreen.SetActive(true);

        Deahscreen.SetActive(false);
        Pausescreen.SetActive(false);
        Gameplayscreen.SetActive(false);
        Time.timeScale = 0f;

    }
    public void APausescreen()
    {
        Time.timeScale = 0f;
        Pausescreen.SetActive(true);

        Deahscreen.SetActive(false);
        Gameplayscreen.SetActive(false);
        winscreen.SetActive(false);
    }
    public void AReset()
    {
        ScoreSystem.scoreValue = 0;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1f;
    }
    public void AQuit()
    {
        ScoreSystem.scoreValue = 0;
        SceneManager.LoadScene(0);
        Time.timeScale = 1f;
    }
}
