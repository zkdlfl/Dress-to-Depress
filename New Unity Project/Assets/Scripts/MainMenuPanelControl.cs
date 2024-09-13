using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenuPanelControl : MonoBehaviour
{
    public GameObject panel;

    public void ShowPanel()
    {
        panel?.SetActive(true);
    }

    public void HidePanel()
    {
        panel?.SetActive(false);
    }

    public void TogglePanel()
    {
        panel?.SetActive(!panel.activeSelf);
    }
}
