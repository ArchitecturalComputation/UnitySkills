using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class CellularAutomata1D
{
    public bool[] Row;
    int _size;

    public CellularAutomata1D(int size)
    {
        _size = size;
        Row = new bool[size];
        Row[size / 2] = true;
    }

    public void NextGeneration()
    {
        var temp = new bool[_size];

        for (int i = 0; i < _size; i++)
        {
            bool next = NextState(i);
            temp[i] = next;
        }

        Row = temp;
    }

    bool NextState(int i)
    {
        bool current = Row[i];
        bool left = i == 0 ? false : Row[i - 1];
        bool right = i == _size - 1 ? false : Row[i + 1];

        if (current && left && right)
            return false;

        if (current && left && !right)
            return true;

        if (!current && left && right)
            return false;

        if (!current && left && !right)
            return true;

        if (current && !left && right)
            return true;

        if (current && !left && !right)
            return false;

        if (!current && !left && right)
            return true;

        if (!current && !left && !right)
            return false;

        throw new System.Exception("Something went wrong");
    }
}
