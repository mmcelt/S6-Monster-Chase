using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collector : MonoBehaviour
{
	#region Unity Methods

	void OnTriggerEnter2D(Collider2D other)
	{
		Destroy(other.gameObject);
	}
	#endregion
}
