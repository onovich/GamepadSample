using UnityEngine;
using UnityEngine.UI;

public class MainPanel : MonoBehaviour {

    [SerializeField] Text text_isMouse;
    [SerializeField] Text text_isKeyboard;
    [SerializeField] Text text_isGamepad;
    [SerializeField] Text text_gamepadName;
    [SerializeField] Text text_isXBoxByName;
    [SerializeField] Text text_isPS4ByName;
    [SerializeField] Text text_isPS5ByName;
    [SerializeField] Text text_isXBoxByType;
    [SerializeField] Text text_isPS4ByType;
    [SerializeField] Text text_isPS5ByType;

    public void SetIsMouse(bool value) {
        text_isMouse.text = value.ToString();
        if (value) {
            text_isMouse.color = Color.yellow;
        } else {
            text_isMouse.color = Color.grey;
        }
    }

    public void SetIsKeyboard(bool value) {
        text_isKeyboard.text = value.ToString();
        if (value) {
            text_isKeyboard.color = Color.yellow;
        } else {
            text_isKeyboard.color = Color.grey;
        }
    }

    public void SetIsGamepad(bool value) {
        text_isGamepad.text = value.ToString();
        if (value) {
            text_isGamepad.color = Color.yellow;
        } else {
            text_isGamepad.color = Color.grey;
        }
    }

    public void SetGamepadName(string value) {
        text_gamepadName.text = value;
        if (value == "No Gamepad Connected") {
            text_gamepadName.color = Color.red;
        } else {
            text_gamepadName.color = Color.white;
        }
    }

    public void SetIsXBoxByName(bool value) {
        text_isXBoxByName.text = value.ToString();
        if (value) {
            text_isXBoxByName.color = Color.yellow;
        } else {
            text_isXBoxByName.color = Color.grey;
        }
    }

    public void SetIsPS4ByName(bool value) {
        text_isPS4ByName.text = value.ToString();
        if (value) {
            text_isPS4ByName.color = Color.yellow;
        } else {
            text_isPS4ByName.color = Color.grey;
        }
    }

    public void SetIsPS5ByName(bool value) {
        text_isPS5ByName.text = value.ToString();
        if (value) {
            text_isPS5ByName.color = Color.yellow;
        } else {
            text_isPS5ByName.color = Color.grey;
        }
    }

    public void SetIsXBoxByType(bool value) {
        text_isXBoxByType.text = value.ToString();
        if (value) {
            text_isXBoxByType.color = Color.yellow;
        } else {
            text_isXBoxByType.color = Color.grey;
        }
    }

    public void SetIsPS4ByType(bool value) {
        text_isPS4ByType.text = value.ToString();
        if (value) {
            text_isPS4ByType.color = Color.yellow;
        } else {
            text_isPS4ByType.color = Color.grey;
        }
    }

    public void SetIsPS5ByType(bool value) {
        text_isPS5ByType.text = value.ToString();
        if (value) {
            text_isPS5ByType.color = Color.yellow;
        } else {
            text_isPS5ByType.color = Color.grey;
        }
    }

}