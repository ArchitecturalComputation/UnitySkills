using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningCode : MonoBehaviour
{
    public GUISkin uiSkin;
    public string text;

    void Start()
    {
        int x = 10;
        int y = 5;
        int result = 10 / 7;
        int remainder = 10 % 7;

        text = $"The result of {x} / {y} is {result} with a remainder of {remainder}";
    }

    private void OnGUI()
    {
        GUI.skin = uiSkin;
        GUI.Label(new Rect(20, 20, 200, 50), text);
    }
}
