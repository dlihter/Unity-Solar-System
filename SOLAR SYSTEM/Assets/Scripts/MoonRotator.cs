using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoonRotator : MonoBehaviour
{
    public Transform earth;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up * Time.deltaTime);
        transform.RotateAround(earth.transform.position, Vector3.up, 50 * Time.deltaTime);
    }
}
