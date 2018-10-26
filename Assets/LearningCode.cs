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

        int result;
        int sum = SumListOfNumbers(numbers, out result);

        text = $"{result}";

        // text = string.Join(", ", numbers);
    }

    private void OnGUI()
    {
        GUI.skin = uiSkin;
        GUI.Label(new Rect(20, 20, 200, 50), text);
    }


    int SumListOfNumbers(List<int> n, out int result)
    {
        int sum = 0;

        foreach (var number in n)
        {
            sum += number;
        }

        result = sum;

        return sum;
    }
}
