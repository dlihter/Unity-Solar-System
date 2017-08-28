using UnityEngine;
using System.Collections;

public class ChangeLookAtTarget : MonoBehaviour
{
	void OnMouseDown()
	{
		LookAtTarget.Target = transform;
	}
}
