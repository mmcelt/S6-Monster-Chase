using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour
{
	#region Fields & Properties

	[HideInInspector] public float _speed;

	Rigidbody2D _theRB;

	#endregion

	#region Getters


	#endregion

	#region Unity Methods

	void Awake()
	{
		_theRB = GetComponent<Rigidbody2D>();
	}

	void Start() 
	{
		
	}
	
	void FixedUpdate() 
	{
		_theRB.velocity = new Vector2(_speed, _theRB.velocity.y);
	}
	#endregion

	#region Public Methods


	#endregion

	#region Private Methods


	#endregion
}
