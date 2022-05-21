using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene(1);
    }
    public void PlayDialog()
    {
        SceneManager.LoadScene(2);
    }
    public void PlayMiniGame()
    {
        SceneManager.LoadScene(3);
    }

    public void PlayBozkurt()
    {
        SceneManager.LoadScene(4);
    }

    public void QuitGame()
    {
        Debug.Log("Çıkış yapıldı!!");
        Application.Quit();
    }

    public void ReturnToMainMenu(){
         SceneManager.LoadScene("Menu");
    }
}
