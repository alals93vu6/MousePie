using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomButton : MonoBehaviour
{
    public void BackHomePage()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(0);
    }
}
