using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidSpawner : MonoBehaviour
{
    public GameObject prefabAsteroid;
    public int numberOfAsteroids = 200;
    public float radius = 75f;

    // Use this for initialization
    void Start ()
    {
        for (int i = 0; i < numberOfAsteroids; i++)
        {
            float angle = i * Mathf.PI * 2 / numberOfAsteroids;
            Vector3 pos = new Vector3(Mathf.Cos(angle), 0, Mathf.Sin(angle)) * radius;
            Instantiate(prefabAsteroid, pos, Quaternion.identity);
        }
    }
}
