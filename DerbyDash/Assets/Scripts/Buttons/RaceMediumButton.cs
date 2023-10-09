using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RaceMediumButton : MonoBehaviour
{
    public void StartMediumRace()
    {
        SceneManager.LoadScene("RaceSceneMedium");
    }
}
