using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CAImage : MonoBehaviour
{
    Texture2D _texture;
    CellularAutomata1D _ca;
    int _size = 60;

    void Start()
    {
        _ca = new CellularAutomata1D(_size);
        _texture = new Texture2D(_size, _size / 2);
        _texture.filterMode = FilterMode.Point;

        for (int i = 0; i < _size / 2; i++)
        {
            PaintRow(i);
            _ca.NextGeneration();
        }

        _texture.Apply();
    }

    void PaintRow(int generation)
    {
        for (int i = 0; i < _size; i++)
        {
            bool state = _ca.Row[i];
            int y = _size / 2 - generation - 1;

            if (state)
                _texture.SetPixel(i, y, Color.black);
        }
    }

    void OnGUI()
    {
        GUI.DrawTexture(new Rect(0, 0, Screen.width, Screen.width / 2), _texture);
    }
}
