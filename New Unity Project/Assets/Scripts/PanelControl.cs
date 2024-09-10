using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelControl : MonoBehaviour
{
    public GameObject panel;

    public void ShowPanel()
    {
        if (panel != null)
        {
            panel.SetActive(true);
        }
    }

    public void HidePanel()
    {
        if (panel != null)
        {
            panel.SetActive(false);
        }
    }

    public void TogglePanel()
    {
        if (panel != null)
        {
            panel.SetActive(!panel.activeSelf);
        }
    }
}
