using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void Start()
    {
        Screen.orientation = ScreenOrientation.Portrait;
    }
    public void ChangeScene()
    {
        SceneManager.LoadScene(1);
    }
    public void ChangeScene2()
    {
        SceneManager.LoadScene(2);
    }
    public void ChangeScene3()
    {
        SceneManager.LoadScene(3);
    }
}
