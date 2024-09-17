using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinishButtonCounter : MonoBehaviour
{
    public Button finishButton;
    public int counter = 0;
    void Start()
    {
        finishButton.onClick.AddListener(IncrementCounter);
    }
    void IncrementCounter()
    {
        counter++;
        Debug.Log("Button clicked! Counter: " + counter);
    }
}
