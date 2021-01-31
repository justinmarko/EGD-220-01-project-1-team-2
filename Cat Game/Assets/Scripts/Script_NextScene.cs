using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Script_NextScene : MonoBehaviour
{
    public void next()
    {
        int nextSceneIndex = SceneManager.GetActiveScene().buildIndex + 1;

        if (SceneManager.sceneCountInBuildSettings > nextSceneIndex)
            SceneManager.LoadScene(nextSceneIndex);
    }

    public void test()
    {
        SceneManager.LoadScene("Test");
    }
}

