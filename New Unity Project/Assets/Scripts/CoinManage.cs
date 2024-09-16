using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Coin : MonoBehaviour
{
    public int coins = 100;
    public TextMeshProUGUI coinText;

    void Start()
    {
        UpdateCoinText();
    }

    public void SpendCoins(int amount)
    {
        if (coins >= amount)
        {
            coins -= amount;
            UpdateCoinText();
            Debug.Log("Coins spent: " + amount);
        }
        else
        {
            Debug.Log("Not enough coins!");
        }
    }

    void UpdateCoinText()
    {
        if (coinText != null)
        {
            coinText.text = "Coins: " + coins.ToString();  // Update the UI text to reflect the current coin count
            Debug.Log("Coin Text updated to: " + coins);
        }
        else
        {
            Debug.LogError("coinText is null and not updating!");
        }
    }
}