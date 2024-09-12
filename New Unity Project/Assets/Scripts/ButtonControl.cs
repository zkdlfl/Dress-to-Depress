using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonControl : MonoBehaviour
{
    public Button mathButton;
    public Button closetButton;
    public Button settingButton;
    public Button settingExitButton;

    public PanelControl mathPanelControl;
    public PanelControl closetPanelControl;
    public PanelControl settingPanelControl;
    public PanelControl settingExitButtonPanelControl;

    void Start()
    {
        if (mathPanelControl != null) mathPanelControl.HidePanel();
        if (closetPanelControl != null) closetPanelControl.HidePanel();
        if (settingPanelControl != null) settingPanelControl.HidePanel();

        mathButton.onClick.AddListener(OnMathButtonClick);
        closetButton.onClick.AddListener(OnClosetButtonClick);
        settingButton.onClick.AddListener(OnSettingButtonClick);
        settingExitButton.onClick.AddListener(OnSettingButtonClick);

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
    void OnSettingButtonClick()
    {
        if (settingPanelControl != null)
        {
            Debug.Log("Here");
            settingPanelControl.TogglePanel();
        }
    }
}

