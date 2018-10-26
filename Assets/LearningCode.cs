using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningCode : MonoBehaviour
{
    public GUISkin uiSkin;

	void Start ()
    {
        Debug.Log("Hello world");
	}

	void Update ()
    {
        Debug.Log("Hello world");
    }

    private void OnGUI()
    {
        GUI.skin = uiSkin;
        GUI.Label(new Rect(20, 20, 200, 50), "Hello world");
    }
}
