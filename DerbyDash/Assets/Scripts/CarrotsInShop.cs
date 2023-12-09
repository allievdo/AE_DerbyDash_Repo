using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CarrotsInShop : MonoBehaviour
{
    public Text carrotAmountText;
    private void Update()
    {
        carrotAmountText.text = PlayerStats.instance.currentCarrots.ToString() + "/3 carrots";
        //Debug.Log(PlayerStats.instance.GetCurrentCarrots());
    }
}
