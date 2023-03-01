using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManagerScript : MonoBehaviour
{
    public GameObject gameOverUi;
    public GameObject winUi;

    public void Win() 
    {
        winUi.SetActive(true);
    }
    public void gameOver()
    {
        gameOverUi.SetActive(true);
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    //public void Quit()
    //{
    //    Application.Quit();
    //    Debug.Log("quit");
    //}
}
