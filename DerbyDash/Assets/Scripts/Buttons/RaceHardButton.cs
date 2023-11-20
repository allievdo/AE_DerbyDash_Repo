using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RaceHardButton : MonoBehaviour
{
    public void StartHardRace()
    {
        SceneManager.LoadScene("RaceSceneHard");
    }
}
