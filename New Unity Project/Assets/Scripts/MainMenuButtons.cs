using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenuButtons : MonoBehaviour
{
    public Button InstructionButton;
    public Button InstructionExitButton;
    public MainMenuPanelControl InstructionButtonPanelControl;
    public MainMenuPanelControl InstructionExitButtonPanelControl;

    void Start()
    {
        if (InstructionButton != null) InstructionButtonPanelControl.HidePanel();
        InstructionButton.onClick.AddListener(OnInstructionButtonPanelControlClick);
        InstructionExitButton.onClick.AddListener(OnInstructionExitButtonClick);
    }
    void OnInstructionExitButtonClick()
    {
        if (InstructionExitButtonPanelControl != null)
        {
            InstructionExitButtonPanelControl.TogglePanel();
        }
    }
    void OnInstructionButtonPanelControlClick()
    {
        if (InstructionButtonPanelControl != null)
        {
            InstructionButtonPanelControl.TogglePanel();
        }
    }
}
