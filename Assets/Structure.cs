using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Structure : MonoBehaviour
{
    public GameObject Box;
    Vector3 _size;

    void Start()
    {
        var collider = Box.GetComponentInChildren<BoxCollider>();
        var size = collider.size * collider.transform.localScale.x;
        _size = size;

       // _size = new Vector3(0.2f, 0.2f, 0.2f);
        Random.InitState(46);

        for (int i = 0; i < 20; i++)
        {
            var go = Instantiate(Box, this.transform);
            //var shiftX = (Random.value - 0.5f) * 0.25f;
            //var shiftZ = (Random.value - 0.5f) * 0.25f;
            var shift = Random.insideUnitCircle * 0.02f;
            go.transform.position = new Vector3(shift.x, i * _size.y, shift.y);
            go.transform.Rotate(0, Random.value * 180, 0);
        }
    }

    void Update()
    {

    }
}
