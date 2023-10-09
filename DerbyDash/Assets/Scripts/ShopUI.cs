using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ShopUI : MonoBehaviour
{
    private Transform container;
    private Transform shopItemTemplate;

    public Text raceAmountText;
    private void Awake()
    {
        container = transform.Find("container"); //grab ref to container
        shopItemTemplate = container.Find("shopItemTemplate"); //inside contrainer, ref for template
        shopItemTemplate.gameObject.SetActive(true); //template is hidden
    }

    private void Start()
    {
        CreateItemButton(HorsesForSale.HorseType.Horse1, "Horse 1", HorsesForSale.GetCost(HorsesForSale.HorseType.Horse1), 0);
        //CreateItemButton(HorsesForSale.HorseType.Horse2, "Horse 2", HorsesForSale.GetCost(HorsesForSale.HorseType.Horse2), 1);
        //CreateItemButton(HorsesForSale.HorseType.Horse3, "Horse 3", HorsesForSale.GetCost(HorsesForSale.HorseType.Horse3), 2);
    }

    private void CreateItemButton(HorsesForSale.HorseType horseType, string horseName, int horseCost, int positionIndex)
    {
        Transform shopItemTransform = Instantiate(shopItemTemplate, container); //why you no show up??
        RectTransform shopItemRectTransform = shopItemTransform.GetComponent<RectTransform>();

        float shopItemHeight = 100f;
        shopItemRectTransform.anchoredPosition = new Vector2(0, -shopItemHeight * positionIndex);

        shopItemTransform.Find("horseName").GetComponent<TextMeshProUGUI>().SetText(horseName);
        shopItemTransform.Find("priceText").GetComponent<TextMeshProUGUI>().SetText(horseCost.ToString());
    }

    public void ButtonClicked()
    {
        PlayerStats.instance.currentMoney -= HorsesForSale.GetCost(HorsesForSale.HorseType.Horse1);
        raceAmountText.text = PlayerStats.instance.currentMoney.ToString();
    }
}
