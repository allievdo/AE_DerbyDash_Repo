using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableHardLevel : MonoBehaviour
{
    public GameObject hardButton;

    private void Update()
    {
        if (FinishLine.isMediumRaceWon == true)
        {
            hardButton.SetActive(true);
        }
    }
}
