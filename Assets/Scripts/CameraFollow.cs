using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
	#region Fields & Properties

	[SerializeField] float _minX, _maxX;

	Transform _player;
	Vector3 _tempPos;

	#endregion

	#region Getters


	#endregion

	#region Unity Methods

	void Start() 
	{
		_player = GameObject.FindWithTag("Player").transform;
	}
	
	void LateUpdate() 
	{
		if (!_player) return;

		_tempPos = transform.position;
		_tempPos.x = _player.position.x;

		_tempPos.x = Mathf.Clamp(_tempPos.x, -61.5f, 61.5f);

		transform.position =_tempPos;
	}
	#endregion

	#region Public Methods


	#endregion

	#region Private Methods


	#endregion
}
