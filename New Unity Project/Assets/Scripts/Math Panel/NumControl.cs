using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NumControl : MonoBehaviour
{
    private int num;
    // private int guessNumber;
    private int countGuess;

    [SerializeField]
    private InputField input;
    [SerializeField]
    private Text text;
    void Awake(){
        num = UnityEngine.Random.Range(0, 11);
        text.text = "Guess a number between 0 and 10!";
    }
    public void GetInput(string guess){
        Debug.Log("You entered " + guess);
        CompareGuesses (int.Parse(guess));
        input.text = "";
    }
    void CompareGuesses(int guess){
        // guessNumber = guess;
        if (guess == num){
            text.text = "Correct! Depositing coins...";
        } else if (guess < num){
            text.text = "Wrong... Guess higher!";
        } else if (guess > num){
            text.text = "Wrong... Guess lower!";
        }
    }
}
