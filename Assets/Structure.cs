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

        Random.InitState(46);

        StartCoroutine(CreateTower());
    }

    IEnumerator CreateTower()
    {
        for (int i = 0; i < 11; i++)
        {
            var go = Instantiate(Box, this.transform);
            var shift = Random.insideUnitCircle * 0.02f;
            go.transform.position = new Vector3(shift.x, i * _size.y, shift.y);
            go.transform.Rotate(0, Random.value * 180, 0);
            yield return new WaitForSeconds(0.5f);
        }
    }

    void Update()
    {

    }
}
