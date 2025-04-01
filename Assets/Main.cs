using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.DualShock;
using UnityEngine.InputSystem.XInput;

public class Main : MonoBehaviour {

    [SerializeField] MainPanel mainPanel;

    void Start() {
        RefreshGamepadInfo();
    }

    void RefreshGamepadInfo() {
        bool isKeyboard = Keyboard.current != null;
        bool isMouse = Mouse.current != null;
        bool isGamepad = Gamepad.current != null;

        bool isXBoxByName = false;
        bool isPS4ByName = false;
        bool isPS5ByName = false;

        bool isXBoxByType = false;
        bool isPS4ByType = false;
        bool isPS5ByType = false;

        if (isGamepad) {
            string gamepadName = Gamepad.current.name;
            isXBoxByName = gamepadName.Contains("Xbox");
            isPS4ByName = gamepadName.Contains("DualShock 4");
            isPS5ByName = gamepadName.Contains("DualSense");

            isXBoxByType = Gamepad.current is XInputController;
            isPS4ByType = Gamepad.current is DualShock4GamepadHID;
            isPS5ByType = Gamepad.current is DualSenseGamepadHID;
        }

        mainPanel.SetIsKeyboard(isKeyboard);
        mainPanel.SetIsMouse(isMouse);
        mainPanel.SetIsGamepad(isGamepad);
        if (isGamepad) {
            mainPanel.SetGamepadName(Gamepad.current.name);
        } else {
            mainPanel.SetGamepadName("No Gamepad Connected");
        }
        mainPanel.SetIsXBoxByName(isXBoxByName);
        mainPanel.SetIsPS4ByName(isPS4ByName);
        mainPanel.SetIsPS5ByName(isPS5ByName);
        mainPanel.SetIsXBoxByType(isXBoxByType);
        mainPanel.SetIsPS4ByType(isPS4ByType);
        mainPanel.SetIsPS5ByType(isPS5ByType);
    }

}