using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menuscript : MonoBehaviour
{
    public void ExitButton() {
        Application.Quit();
        Debug.Log("Game Closed");
    }

    public void StartGame() {
        SceneManager.LoadScene("Level 1");
    }

    public void DemoScene() {
        SceneManager.LoadScene("assetsDisplay");
    }

}
