using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public int lastLevel = 2;
    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void ShowMainMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void LoadAgain()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void NextLevel() 
    {
        if (lastLevel >= SceneManager.GetActiveScene().buildIndex)
            ShowMainMenu();
        else 
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void QuitGame()
    {
        Debug.Log("Quited game");
        
        // For debug mode
        //UnityEditor.EditorApplication.isPlaying = false;
        Application.Quit();
    }
}
