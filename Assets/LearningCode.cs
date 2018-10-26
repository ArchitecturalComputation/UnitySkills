using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningCode : MonoBehaviour
{
    public GUISkin uiSkin;
    public string text;

    void Start()
    {
        int color = 1;

        switch (color)
        {
            case 1:
                text = "red";
                break;
            case 2:
                text = "green";
                break;
            case 3:
                text = "blue";
                break;
            default:
                text = "unknown color";
                break;
        }


        //if (condition)
        //{

        //    text = $"{x} is greater than {y}.";
        //}
        //else
        //{
        //    text = $"{x} is smaller or equal to {y}";
        //}
    }

    private void OnGUI()
    {
        GUI.skin = uiSkin;
        GUI.Label(new Rect(20, 20, 200, 50), text);
    }
}
