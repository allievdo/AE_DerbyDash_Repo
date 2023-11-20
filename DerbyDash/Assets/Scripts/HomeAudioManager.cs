using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HomeAudioManager : MonoBehaviour
{
    private void Awake()
    {
        GameObject[] homeMusic = GameObject.FindGameObjectsWithTag("Music");
        if(homeMusic.Length > 1)
        {
            Destroy(this.gameObject);
        }
        DontDestroyOnLoad(this.gameObject);
    }
}
