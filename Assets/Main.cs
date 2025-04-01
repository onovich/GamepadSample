using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Controls;
using UnityEngine.InputSystem.DualShock;
using UnityEngine.InputSystem.Utilities;
using UnityEngine.InputSystem.XInput;

public class Main : MonoBehaviour {

    [SerializeField] MainPanel mainPanel;

    void Start() {
        RefreshControllerInfo(null);
    }

    void Update() {
        var gamepad = Gamepad.current;
        if (gamepad == null) return; // 没有连接手柄时退出
        foreach (var button in gamepad.allControls) {
            if (button is ButtonControl btn && btn.wasPressedThisFrame) {
                string keyPath = button.path;
                RefreshControllerInfo(keyPath);
                break;
            }
        }

        if (Keyboard.current != null) {
            foreach (var key in Keyboard.current.allKeys) {
                if (key.wasPressedThisFrame) {
                    string keyPath = key.path;
                    RefreshControllerInfo(keyPath);
                    break;
                }
            }
        }

        var mouse = Mouse.current;
        if (mouse != null) {
            foreach (var control in mouse.allControls) {
                if (control is ButtonControl button && button.wasPressedThisFrame) {
                    RefreshControllerInfo(button.path);
                    break;
                }
            }
        }

        if (Input.GetKeyDown(KeyCode.Escape)) {
            Application.Quit();
        }
    }

    void RefreshControllerInfo(string keyPath) {
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

        if (keyPath == null) {
            keyPath = "No Key Pressed";
        } else {
            mainPanel.SetKeyPath(keyPath);
        }
    }

}