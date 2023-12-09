using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HorseshoesInShop : MonoBehaviour
{
    public Text horseshoeAmountText;
    private void Update()
    {
        horseshoeAmountText.text = PlayerStats.instance.horseShoes.ToString() + "/1 horseshoes";
        //Debug.Log(PlayerStats.instance.GetCurrentApples());
    }
}
