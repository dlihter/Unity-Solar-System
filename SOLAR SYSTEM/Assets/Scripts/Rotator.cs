using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    private float speed;

	// Use this for initialization
	void Start ()
    {
        speed = Random.Range(5, 50);
	}
	
	// Update is called once per frame
	void Update ()
    {
        transform.Rotate(Vector3.up * 30 * Time.deltaTime);
        transform.RotateAround(Vector3.zero, Vector3.up, speed * Time.deltaTime);
	}
}
