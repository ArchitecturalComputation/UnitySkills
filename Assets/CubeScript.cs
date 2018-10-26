using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeScript : MonoBehaviour
{

	void Start ()
    {

	}

	void Update ()
    {
        var delta = new Vector3(0.01f, 0, 0);
        transform.position += delta;
    }
}
