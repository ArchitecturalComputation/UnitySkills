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

        //StartCoroutine(CreateTower());
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
    }
}
