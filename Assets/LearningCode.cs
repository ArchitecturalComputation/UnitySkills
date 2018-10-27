using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningCode : MonoBehaviour
{
    public GUISkin uiSkin;
    public string text;

    void Start()
    {
        var numbers = new List<int>();

        for (int i = 0; i < 10; i++)
        {
            if (i == 5)
                continue;

            numbers.Add(i);
        }

        numbers[0] = 5;

        var numbersB = numbers;
        numbers[0] = 10;

       // "value types": int,float, Rect, Vector3, Vector2,
      //  "reference types":  int[], List<int>, uiSkin

        ModifyList(numbers);
        int result = numbers[0];
      
        text = $"{result}";

        // text = string.Join(", ", numbers);
    }

    private void OnGUI()
    {
        GUI.skin = uiSkin;
        GUI.Label(new Rect(20, 20, 200, 50), text);
    }


    void ModifyList(List<int> n)
    {
        n = new List<int>();
      //  n[0] = 6;
    }
}
