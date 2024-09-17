using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Level : MonoBehaviour
{
    public TMP_Text LevelText;
    public FinishButtonCounter finishButtonCounter;
    public int scorevalue;
    void Start()
    {
        scorevalue = finishButtonCounter.counter;
    }
    void Update()
    {
        LevelText.text = "Score: " + scorevalue.ToString();
    }
}
