using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StageManager : MonoBehaviour
{
    Scene currentScene;

    private void Update()
    {
        currentScene = SceneManager.GetActiveScene();
        if (currentScene.name == "Victory")
        {
            if (Input.GetKeyDown("x") || Input.GetKeyDown("c") || Input.GetKeyDown("v"))
            {
                Hub();
            }
        }

        if (currentScene.name == "GameOver")
        {
            if (Input.GetKeyDown("x") || Input.GetKeyDown("c") || Input.GetKeyDown("v"))
            {
                PreviousScene();
            }
        }
    }

    public void Hub()
    {
        SceneManager.LoadScene("Hub");
    }

    public void PreviousScene()
    {
        SceneManager.LoadScene(LastScene.lastScene);
    }
}