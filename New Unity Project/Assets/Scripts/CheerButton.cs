using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CheerButton : MonoBehaviour
{
    public Button cheerButton;
    public AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        if (cheerButton != null)
        cheerButton.onClick.AddListener(OnCheerButtonClick);
    }

    // Update is called once per frame
    void OnCheerButtonClick()
    {
        Debug.Log("Cheer");
        audioSource.Play();
    }
}
