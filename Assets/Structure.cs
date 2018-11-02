using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Structure : MonoBehaviour
{
    public GameObject Cube;

    void Start()
    {
        Random.InitState(42);

        for (int i = 0; i < 10; i++)
        {
            var go = Instantiate(Cube, this.transform);
            //var shiftX = (Random.value - 0.5f) * 0.25f;
            //var shiftZ = (Random.value - 0.5f) * 0.25f;
            var shift = Random.insideUnitCircle * 0.2f;
            go.transform.position = new Vector3(shift.x, i + 0.5f, shift.y);
            go.transform.Rotate(0, Random.value * 180, 0);
        }
    }

    void Update()
    {

    }
}
