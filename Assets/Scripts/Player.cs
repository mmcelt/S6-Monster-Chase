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
		AnimatePlayer();
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

	void AnimatePlayer()
	{
		if (_movementX > 0)	//moving to right
		{
			_theAnim.SetBool(WALK_ANIMATION, true);
			_theSR.flipX = false;
		}
		else if (_movementX < 0)	//moving to left
		{
			_theAnim.SetBool(WALK_ANIMATION, true);
			_theSR.flipX = true;
		}
		else
		{
			//standing still
			_theAnim.SetBool(WALK_ANIMATION, false);
		}
	}
	#endregion
}
