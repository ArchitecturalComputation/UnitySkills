using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Structure : MonoBehaviour
{
    public GameObject Cube;

    void Start()
    {
        var go = Instantiate(Cube, this.transform);
        go.transform.position += Vector3.right * 3;
    }

    void Update()
    {

    }
}
