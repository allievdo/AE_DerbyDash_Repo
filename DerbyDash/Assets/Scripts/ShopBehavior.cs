using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopBehavior : MonoBehaviour
{
    public Text raceAmountText;
    public Text numOfCarrots;
    public Text numOfApples;

    PlayerStats _playerStats;

    public void CarrotButtonClicked()
    {
        if (PlayerStats.instance.currentMoney >= 30)
        {
            if (PlayerStats.instance.currentCarrots >= 3)
            {
                Debug.Log("No more carrots allowed");
            }
            else
            {
                PlayerStats.instance.currentMoney -= 30;
                raceAmountText.text = "$" + PlayerStats.instance.currentMoney.ToString();
                PlayerStats.instance.currentCarrots += 1;
                numOfCarrots.text = PlayerStats.instance.currentCarrots.ToString() + "/3 carrots";
            }
        }

        else
        {
            Debug.Log("You do not have enough money for this item");
        }
    }

    public void AppleButtonClicked()
    {
        if (PlayerStats.instance.currentMoney >= 100)
        {
            if (PlayerStats.instance.currentApples >= 1)
            {
                Debug.Log("No more apples allowed");
            }
            else
            {
                PlayerStats.instance.currentMoney -= 100;
                raceAmountText.text = "$" + PlayerStats.instance.currentMoney.ToString();
                PlayerStats.instance.currentApples += 1;
                numOfApples.text = PlayerStats.instance.currentApples.ToString() + "/1 apples";
            }
        }

        else
        {
            Debug.Log("You do not have enough money for this item");
        }
    }
}
