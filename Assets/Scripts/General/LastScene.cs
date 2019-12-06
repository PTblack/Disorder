using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public static class LastScene
{
    public static string lastScene;

    public static string GetCurrentSceneName()
    {
        lastScene = SceneManager.GetActiveScene().name;
        return lastScene;
    }

}
