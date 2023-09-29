using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StableButton : MonoBehaviour
{
    public void EnterStable()
    {
        SceneManager.LoadScene("StableScene");
    }
}
