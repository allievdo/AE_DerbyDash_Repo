using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopBehavior : MonoBehaviour
{
    public Text raceAmountText;
    public Text numOfCarrots;

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
                numOfCarrots.text = PlayerStats.instance.currentCarrots.ToString() + " carrots";
            }
        }

        else
        {
            Debug.Log("You do not have enough money for this item");
        }
    }
}
