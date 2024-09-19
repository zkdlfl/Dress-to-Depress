using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Clothing : MonoBehaviour
{
    public TextMeshProUGUI coinText;
    public int coins = 100;
    public Button[] clothButtons;
    public int[] clothPrices = { 10, 10, 10, 25, 25, 25, 50, 50, 50 };

    void Start()
    {
        UpdateCoinText();
        AssignClothingButtons();

    }

    void AssignClothingButtons()
    {
        for (int i = 0; i < clothButtons.Length; i++)
        {
            int index = i;
            clothButtons[i].onClick.AddListener(() => PurchaseClothing(index));
        }
    }

    void PurchaseClothing(int clothIndex)
    {
        int price = clothPrices[clothIndex];

        if (coins >= price)
        {
            coins -= price;
            UpdateCoinText();
            Debug.Log("Cloth purchased! Remaining coins: " + coins);
        }
        else
        {
            Debug.Log("Not enough coins!");
        }
    }

    void UpdateCoinText()
    {
        coinText.text = "Coins: " + coins.ToString();
    }
}