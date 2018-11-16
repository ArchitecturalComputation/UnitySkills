using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CA : MonoBehaviour
{
    public GameObject Box;
    int _size = 60;
    CellularAutomata1D _ca;

    void Start()
    {
        _ca = new CellularAutomata1D(_size);
        StartCoroutine(CreateCA());

    }

    IEnumerator CreateCA()
    {
        for (int i = 0; i < _size / 2; i++)
        {
            StartCoroutine(CreateRow(i));
            yield return new WaitForSeconds(0.1f);
            _ca.NextGeneration();
        }
    }

    IEnumerator CreateRow(int generation)
    {
        var row = (bool[])_ca.Row.Clone();
        int halfSize = _size / 2;

        for (int i = 0; i < _size; i++)
        {
            bool state = row[i];

            if (state)
            {

                var box = Instantiate(Box, this.transform);
                float x = (i - halfSize) * 0.2f;
                float y = (halfSize - generation - 1) * 0.2f;
                box.transform.position = new Vector3(x, y, 0);
            }

            yield return new WaitForSeconds(0.05f);
        }
    }
}
