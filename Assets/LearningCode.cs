using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningCode : MonoBehaviour
{
    public GUISkin uiSkin;
    public string text;

    void Start()
    {
        //int[] numbers = new int[5];
        // numbers[2] = 5;

        var numbers = new List<int>();
        numbers.Add(5);
        numbers[0] = 3;
        
        text = string.Join(", ", numbers);
    }

    private void OnGUI()
    {
        GUI.skin = uiSkin;
        GUI.Label(new Rect(20, 20, 200, 50), text);
    }
}
