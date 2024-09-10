using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonControl : MonoBehaviour
{
    public Button mathButton;
    public Button closetButton;

    public PanelControl mathPanelControl;
    public PanelControl closetPanelControl;

    void Start()
    {
        if (mathPanelControl != null) mathPanelControl.HidePanel();
        if (closetPanelControl != null) closetPanelControl.HidePanel();

        mathButton.onClick.AddListener(OnMathButtonClick);
        closetButton.onClick.AddListener(OnClosetButtonClick);

    }
    void OnMathButtonClick()
    {
        if (mathPanelControl != null)
        {
            mathPanelControl.TogglePanel();
        }
    }

    void OnClosetButtonClick()
    {
        if (closetPanelControl != null)
        {
            closetPanelControl.TogglePanel();
        }
    }
}

