using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeScript : MonoBehaviour
{
    MeshRenderer _renderer;
    Rigidbody _rb;

    void Start()
    {
        _renderer = GetComponent<MeshRenderer>();
        _rb = GetComponent<Rigidbody>();

        var material = _renderer.material;

        material.color = Color.white * Random.Range(0.4f, 0.8f);
        //  material.color = Random.ColorHSV(0.5f, 0.7f, 0.8f, 0.8f, 0.8f, 0.8f);
    }

     void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            var mouse = Input.mousePosition;
            var ray = Camera.main.ScreenPointToRay(mouse);

            if(Physics.Raycast(ray, out hit))
            {
                if (hit.collider.gameObject != this.gameObject)
                    return;

                var force = -hit.normal * 5;
                _rb.AddForce(force, ForceMode.Impulse);

            }
        }
    }

    //void OnMouseDown()
    //{
    //    var force = new Vector3(0, 10, 0);
    //    _rb.AddForce(force, ForceMode.Impulse);
    //    // _renderer.material.color = Color.black;
    //    //   StartCoroutine(DestroyBox());
    //}

    IEnumerator DestroyBox()
    {
        yield return new WaitForSeconds(5.0f);
        Destroy(this.gameObject);
    }
}
