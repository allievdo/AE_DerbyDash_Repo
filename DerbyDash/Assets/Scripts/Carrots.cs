using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Carrots : MonoBehaviour
{
    public Text carrotAmountText;
    private void Update()
    {
        carrotAmountText.text = PlayerStats.instance.currentCarrots.ToString() + " carrots";
        //Debug.Log(PlayerStats.instance.GetCurrentCarrots());
    }
}
