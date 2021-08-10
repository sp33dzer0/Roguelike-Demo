using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class sceneChanger : MonoBehaviour
{
    public static int buildScene = 0;

    public void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    public static void ToMainMenu()
    {
        buildScene = 0;
        SceneManager.LoadScene("MainMenu");
    }

    public static void ToCampsite()
    {
        buildScene = 1;
        SceneManager.LoadScene("Campsite");
    }

    public static void ToMines()
    {
        buildScene = 2;
        SceneManager.LoadScene("Mines");
    }

    public static void ToCastle()
    {
        buildScene = 3;
        SceneManager.LoadScene("Castle");
    }
}
