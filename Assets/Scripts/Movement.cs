using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private float _speed;

    void Update()
    {
        if (Input.GetKey(KeyCode.W) == true)
        { transform.Translate(0, 1 * _speed * Time.deltaTime, 0); }

        if (Input.GetKey(KeyCode.S) == true)
        { transform.Translate(0, -1 * _speed * Time.deltaTime, 0); }
    }
}
