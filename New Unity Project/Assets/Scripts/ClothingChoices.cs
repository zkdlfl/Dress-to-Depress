using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Clothing : MonoBehaviour
{
    public GameObject clothingButtonPrefab;
    public GameObject clothingButtonParent;
    public List<int> clothingPrices;
    public Coin coinManager;

    void Start()
    {
        GenerateClothingButtons();
    }

    void GenerateClothingButtons()
    {
        for (int i = 0; i < clothingPrices.Count; i++)
        {
            GameObject newButton = Instantiate(clothingButtonPrefab, clothingButtonParent.transform);
            int price = clothingPrices[i];

            newButton.GetComponentInChildren<TextMeshProUGUI>().text = "Clothing " + (i + 1) + " - " + price + " coins";

            int index = i;
            newButton.GetComponent<Button>().onClick.AddListener(() => PurchaseClothing(index));
        }
    }

    void PurchaseClothing(int index)
    {
        int price = clothingPrices[index];

        if (coinManager.coins >= price)
        {
            coinManager.SpendCoins(price);
            Debug.Log("Purchased clothing item " + (index + 1));
        }
        else
        {
            Debug.Log("Not enough coins!");
        }
    }
}
