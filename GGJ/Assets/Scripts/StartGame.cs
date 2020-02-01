using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    public void StartPlayingGame()
    {
        Debug.Log("Start");
        SceneManager.LoadScene("Level00", LoadSceneMode.Single);
    }
}
