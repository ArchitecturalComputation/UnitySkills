using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeScript : MonoBehaviour
{
    public float translationSpeed = 1f;
    public float rotationSpeed = 10.0f;

    int direction = 1;

    void Start() {   }

    void Update()
    {
        

        if (transform.position.x > 4)
        {
            direction = -1;
        }

        if (transform.position.x < -4)
        {
            direction = 1;
        }

        var delta = Vector3.right * translationSpeed;
        delta *= Time.deltaTime;

        var rotation = rotationSpeed * direction;
        rotation *= Time.deltaTime;

        transform.position += delta * direction;
        transform.Rotate(0, rotation, 0);
    }
}
