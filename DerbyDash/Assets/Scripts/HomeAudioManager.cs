using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HomeAudioManager : MonoBehaviour
{
    private void Awake()
    {
        GameObject[] homeMusic = GameObject.FindGameObjectsWithTag("Music");

        if (SceneManager.GetActiveScene().name == "HomeScene" ||  SceneManager.GetActiveScene().name == "HomeSceneMain" || SceneManager.GetActiveScene().name == "RaceSelection")
        {
            DontDestroyOnLoad(this.gameObject);
        }

        if (SceneManager.GetActiveScene().name == "RaceScene")
        {
            Destroy(this.gameObject);
        }
    }
}
