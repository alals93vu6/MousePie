using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HomePageButton : MonoBehaviour
{    
    public void BackHomePage()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(0);
    }
    public void Seting()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(1);
    }
    public void CreateRoom()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(2);
    }
    public void JoinRoom()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(3);
    }
    public void Winner()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(4);
    }
    public void Loser()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(5);
    }
    public void QuitGame()
    {
        Application.Quit();
    }

    public void GGG()
    {
        Debug.Log("AAA");
    }
}
