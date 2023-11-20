using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Apples : MonoBehaviour
{
    public Text appleAmountText;
    private void Update()
    {
        appleAmountText.text = PlayerStats.instance.currentApples.ToString() + " apples";
        Debug.Log(PlayerStats.instance.GetCurrentApples());
    }
}
