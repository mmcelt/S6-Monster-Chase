using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
	#region Fields & Properties

	public static Action PlayerDied;

	[SerializeField] float _moveForce = 10f;
	[SerializeField] float _jumpForce = 11f;

	float _movementX;
	string WALK_ANIMATION = "Walk";
	string GROUND_TAG = "Ground";
	string ENEMY_TAG = "Enemy";

	bool _jump, _isGrounded;

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
		_isGrounded = true;
	}
	
	void Update() 
	{
		PlayerMoveKeyboard();
		AnimatePlayer();

		if (Input.GetButtonDown("Jump") && _isGrounded)
		{
			CallPlayerJump();
		}
	}

	void FixedUpdate()
	{
		if(_jump)
			PlayerJump();
	}

	void OnCollisionEnter2D(Collision2D other)
	{
		if (other.gameObject.CompareTag(GROUND_TAG))
			_isGrounded = true;

		if (other.gameObject.CompareTag(ENEMY_TAG))
		{
			Destroy(gameObject);
			PlayerDied?.Invoke();
		}
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.CompareTag(ENEMY_TAG))
		{
			Destroy(gameObject);
			PlayerDied?.Invoke();
		}
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

	void CallPlayerJump()
	{
		_jump = true;
		_isGrounded = false;
	}

	void PlayerJump()
	{
		//if (Input.GetButtonDown("Jump"))
		//{
			_theRB.AddForce(new Vector2(0f, _jumpForce), ForceMode2D.Impulse);
		_jump = false;
		//}
	}
	#endregion
}
