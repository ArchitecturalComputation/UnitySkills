using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Structure : MonoBehaviour
{
    public GameObject Box;
    Vector3 _size;
    List<GameObject> _boxes = new List<GameObject>();

    void Start()
    {
        var collider = Box.GetComponentInChildren<BoxCollider>();
        var size = collider.size * collider.transform.localScale.x;
        _size = size;
        Random.InitState(46);


        //var rb = Box.GetComponent<Rigidbody>();
        //rb.AddForce(Vector3.up);
        GameObject go = null;
        Debug.Log(go);

        if (go != null)
            go.transform.position = new Vector3(0, 1, 0);

        StartCoroutine(CreateTower());
    }

    IEnumerator CreateTower()
    {

        foreach (var box in _boxes)
        {
            Destroy(box);
        }

        _boxes.Clear();

        for (int i = 0; i < 11; i++)
        {
            var go = Instantiate(Box, this.transform);
            var shift = Random.insideUnitCircle * 0.02f;
            go.transform.position = new Vector3(shift.x, i * _size.y, shift.y);
            go.transform.Rotate(0, Random.value * 180, 0);
            _boxes.Add(go);
            yield return new WaitForSeconds(0.2f);
        }
    }

    IEnumerator CreateWall()
    {

        foreach (var box in _boxes)
        {
            Destroy(box);
        }

        _boxes.Clear();

        int rowCount = 10;

        for (int i = 0; i < 50; i++)
        {
            int layer = i / rowCount;
            int column = i % rowCount;
            float x = column * _size.x;
            float y = layer * _size.y;
            var go = Instantiate(Box, this.transform);

            go.transform.position = new Vector3(x, y, 0);
           // go.transform.Rotate(0, Random.value * 180, 0);
            _boxes.Add(go);
            yield return new WaitForSeconds(0.2f);
        }
    }

    IEnumerator _coroutine = null;

    void OnGUI()
    {
        if (GUI.Button(new Rect(20, 20, 100, 40), "Create tower"))
        {
            if (_coroutine != null)
                StopCoroutine(_coroutine);

            _coroutine = CreateTower();
            StartCoroutine(_coroutine);
        }

        if (GUI.Button(new Rect(20, 80, 100, 40), "Create wall"))
        {
            if (_coroutine != null)
                StopCoroutine(_coroutine);

            _coroutine = CreateWall();
            StartCoroutine(_coroutine);
        }
    }
}
