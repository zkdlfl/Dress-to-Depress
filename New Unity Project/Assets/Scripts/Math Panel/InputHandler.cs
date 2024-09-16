// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;
// using UnityEngine.UI;

// public class InputHandler : MonoBehaviour
// {
//    public Text resultText;
//    public InputField guessInput;
//    public int randNum;

//    public void NumGeneration()
//    {
//         randNum = Random.range(1, 11);
//    }

//    public void GetGuess()
//    {
//         string guessString = guessInput.text;
//         int guessInt = System.Convert.ToInt32 (guessString);
//         if (guessInt = randNum)
//         {
//             resultText.text = "Correct! Depositing coins...";
//         }
//         else
//         {
//             resultText.text = "Wrong, the number was " + randNum + " . " "Please try again...";
//             randNum = Random.range(1, 11);
//         }
//    }
// }


// // [SerializedField] InputField inputField;
// //    [SerializedField] Text resultText;

// //     public void RandomNumber()
// //     {
// //         Random random = new Random()
// //         bool playAgain = true;
// //         int min = 1;
// //         int max = 10;
// //         int guess;
// //         int number;

// //         while (playAgain)
// //         {
// //             guess = 0
// //             number = random.next(min, max + 1)

// //             while (guess != number)
// //             {
// //                 string input = inputField.text;

// //                 if (input.Text = int randnum)
// //                     {
// //                         resultText.text = "Correct! Depositing coins..."
// //                     }
// //                 else
// //                     {
// //                         resultText.text = "Wrong, try again..."
// //                     }
// //             }
// //         }
// //     }

// //     public void ValidateInput()
// //     {
// //         // Random rng = new Random();
// //         // int randnum = rng.Next(10);



// //         string input = inputField.text;

// //         if (input.Text = int randnum)
// //         {
// //             resultText.text = "Correct! Depositing coins..."
// //         }
// //         else
// //         {
// //             resultText.text = "Wrong, try again..."
// //         }
        
// //     }