using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
	#region Fields & Properties

	[SerializeField] float _moveForce = 10f;
	[SerializeField] float _jumpForce = 11f;

	float _movementX;
	string WALK_ANIMATION = "Walk";

	Rigidbody2D _theRB;
	Animator _theAnim;
	SpriteRenderer _theSR;

	#endregion

	#region Getters


	#endregion

	#region Unity Methods

	void Awake()
	{
		_theRB = GetComponent<Rigidbody2D>();
		_theAnim = GetComponent<Animator>();
		_theSR = GetComponent<SpriteRenderer>();
	}

	void Start() 
	{

	}
	
	void Update() 
	{
		PlayerMoveKeyboard();
	}
	#endregion

	#region Public Methods


	#endregion

	#region Private Methods

	void PlayerMoveKeyboard()
	{
		_movementX = Input.GetAxisRaw("Horizontal");
		transform.position += new Vector3(_movementX, 0f, 0f) * _moveForce * Time.deltaTime;
	}
	#endregion
}
