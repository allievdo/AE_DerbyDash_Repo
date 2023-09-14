using UnityEngine;
using UnityEngine.SceneManagement;

public class RaceButton : MonoBehaviour
{
    public void StartRace()
    {
        SceneManager.LoadScene("RaceScene");
    }
}
