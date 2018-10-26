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

        int sum = 0;

        int j = 0;
        while (j < numbers.Count)
        {
            sum += numbers[j++];
        }

        //foreach (int number in numbers)
        //{
        //    sum += number;
        //}



        text = $"{sum}";
        // text = string.Join(", ", numbers);
    }

    private void OnGUI()
    {
        GUI.skin = uiSkin;
        GUI.Label(new Rect(20, 20, 200, 50), text);
    }
}
