﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateRing : MonoBehaviour
{
	// Update is called once per frame
	void Update ()
    {
        transform.Rotate(new Vector3(0.0f, 90, 0.0f) * 100 * Time.deltaTime);	
	}
}
