using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbitCamera : MonoBehaviour
{
    private Vector3 Axis;

    // Use this for initialization
    void Start()
    {
        Axis.x = Random.Range(-10, 10);
        Axis.y = Random.Range(-10, 10);
        Axis.z = Random.Range(-10, 10);
    }

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(Vector3.zero, Axis, 10 * Time.deltaTime);
    }
}
