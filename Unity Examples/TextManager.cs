using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextManager : MonoBehaviour
{
    public Text textbox;

    public void DisplayMessage()
    {
        textbox.text = "Test Message";
    }
}
