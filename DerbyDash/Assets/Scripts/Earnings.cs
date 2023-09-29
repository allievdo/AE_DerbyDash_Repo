using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Earnings : MonoBehaviour
{
    public Text raceAmountText;
    private void Start()
    {
        raceAmountText.text = PlayerStats.instance.currentMoney.ToString();
    }
}
