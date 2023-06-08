using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static void ReturnToMainMenu()
    {
        SceneManager.LoadScene("Menu"); 
    }
}