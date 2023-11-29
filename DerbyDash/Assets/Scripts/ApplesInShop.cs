using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ApplesInShop : MonoBehaviour
{
    public Text appleAmountText;
    private void Update()
    {
        appleAmountText.text = PlayerStats.instance.currentApples.ToString() + "/1 apples";
        Debug.Log(PlayerStats.instance.GetCurrentApples());
    }
}
