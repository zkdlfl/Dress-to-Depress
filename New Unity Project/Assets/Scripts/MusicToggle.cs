using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class MusicToggle : MonoBehaviour
{
    public AudioSource audioSource;
    public Button audioButton;
    public TextMeshProUGUI buttonText;
    private bool isMusicPlaying = true; 

    // Start is called before the first frame update
    void Start()
    {
        if (audioButton != null)
        audioButton.onClick.AddListener(OnAudioButtonClick);

        UpdateButtonText();
    }

    // Update is called once per frame
    void UpdateButtonText()
    {
        if (buttonText != null)
        {
            buttonText.text = isMusicPlaying ? "Audio: On" : "Audio: Off";
        }
    }
    void OnAudioButtonClick()
    {
        isMusicPlaying = !isMusicPlaying;
        
        if (audioSource != null) 
        {
            audioSource.mute = !isMusicPlaying;
        }

        UpdateButtonText();
    }
}
