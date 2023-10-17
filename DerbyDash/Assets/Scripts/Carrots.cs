using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Carrots : MonoBehaviour
{
    public Text carrotAmountText;
    private void Start()
    {
        carrotAmountText.text = PlayerStats.instance.currentCarrots.ToString() + " carrots";
    }
}
