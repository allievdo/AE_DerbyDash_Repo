using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackToHomeButton : MonoBehaviour
{
    public void GoBack()
    {
        if (FinishLine.isHardRaceWon)
        {
            SceneManager.LoadScene("HomeSceneCompleteHard");
        }
        else
        {
            SceneManager.LoadScene("HomeSceneMain");
        }
    }
}
