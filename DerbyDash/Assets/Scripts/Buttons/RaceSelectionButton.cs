using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RaceSelectionButton : MonoBehaviour
{
    public void StartRaceSelection()
    {
        SceneManager.LoadScene("RaceSelection");
    }
}
