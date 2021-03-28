using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterSpawner : MonoBehaviour
{
	#region Fields & Properties

	[SerializeField] GameObject[] _monsterPrefabs;
	[SerializeField] Transform _leftPos, _rightPos;

	GameObject _spawnedMonster;
	int _randomIndex, _randomSide;

	#endregion

	#region Getters


	#endregion

	#region Unity Methods

	void Start() 
	{
		StartCoroutine(SpawnMonstersRoutine());
	}
	#endregion

	#region Public Methods


	#endregion

	#region Private Methods

	IEnumerator SpawnMonstersRoutine()
	{
		while (true)
		{
			yield return new WaitForSeconds(Random.Range(1, 6));

			_randomIndex = Random.Range(0, _monsterPrefabs.Length);
			_randomSide = Random.Range(0, 2);
			_spawnedMonster = Instantiate(_monsterPrefabs[_randomIndex]);

			if (_randomSide == 0)   //left side
			{
				_spawnedMonster.transform.position = _leftPos.position;
				_spawnedMonster.GetComponent<Monster>()._speed = Random.Range(4f, 10f);
			}
			else
			{
				_spawnedMonster.transform.position = _rightPos.position;
				_spawnedMonster.GetComponent<Monster>()._speed = -Random.Range(4f, 10f);
				_spawnedMonster.GetComponent<SpriteRenderer>().flipX = true;
			}
		}
	}
	#endregion
}
