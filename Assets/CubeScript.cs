using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeScript : MonoBehaviour
{
    MeshRenderer _renderer;

    void Start()
    {
        _renderer = GetComponent<MeshRenderer>();
        var material = _renderer.material;

        material.color = Color.white * Random.Range(0.4f, 0.8f);
        //  material.color = Random.ColorHSV(0.5f, 0.7f, 0.8f, 0.8f, 0.8f, 0.8f);
    }

    void OnMouseDown()
    {
        _renderer.material.color = Color.black;
    }
}
