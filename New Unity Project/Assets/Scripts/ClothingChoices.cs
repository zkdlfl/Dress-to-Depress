using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Clothing : MonoBehaviour
{
    public GameObject clothingButtonPrefab;
    public GameObject clothingButtonParent;
    public List<int> clothingPrices;
    public Text coinText;
    public int playerCoins;

    void Start()
    {
        GenerateClothingButtons();
        UpdateCoinText();
    }

    void GenerateClothingButtons()
    {
        for (int i = 0; i < clothingPrices.Count; i++)
        {
            GameObject newButton = Instantiate(clothingButtonPrefab, clothingButtonParent.transform);
            int price = clothingPrices[i];
            newButton.GetComponentInChildren<Text>().text = "Clothing " + (i + 1) + " - " + price + " coins";

            int index = i;
            newButton.GetComponent<Button>().onClick.AddListener(() => PurchaseClothing(index));
        }
    }

    void PurchaseClothing(int index)
    {
        int price = clothingPrices[index];

        if (playerCoins >= price)
        {
            playerCoins -= price;
            UpdateCoinText();
            Debug.Log("Purchased clothing item " + (index + 1));
        }
        else
        {
            Debug.Log("Not enough coins!"); // Corrected with a semicolon here
        }
    }

    void UpdateCoinText()
    {
        coinText.text = "Coins: " + playerCoins.ToString();
    }
}
