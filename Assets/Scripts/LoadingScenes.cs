using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadingScenes : MonoBehaviour
{
    private ReturnScene countScene;

    private void Start()
    {
        countScene = GetComponent<ReturnScene>();
    }

    public void PlayGame()
    {
        int count = ReturnScene.count;

        if (count == 0 || count != 0)
        {
            SceneManager.LoadScene(1);
        }
    }

    public void Settings()
    {
        SceneManager.LoadScene(2);
    }

    public void Rules()
    {
        SceneManager.LoadScene(3);
    }

    public void QuitGame()
    {
        Debug.Log("Quit");
    }
}