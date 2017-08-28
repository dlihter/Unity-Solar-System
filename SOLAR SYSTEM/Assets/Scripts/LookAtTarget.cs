using UnityEngine;
using System.Collections;

public class LookAtTarget : MonoBehaviour
{
	public static Transform Target;

	// Use this for initialization
	void Start ()
	{
		if (!Target)
			Debug.LogError ("Target is not defined!");
	}

    // Update is called once per frame
    void Update()
    {
        if (Target)
        {
            transform.LookAt(Target.position);
        }
	}
}
