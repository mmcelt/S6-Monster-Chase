using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
	#region Fields & Properties

	public static GameManager Instance;

	[SerializeField] GameObject[] _players;

	int _playerIndex;

	public int PlayerIndex
	{
		get { return _playerIndex; }
		set { _playerIndex = value; }
	}

	#endregion

	#region Getters


	#endregion

	#region Unity Methods

	void Awake()
	{
		if (Instance == null)
		{
			Instance = this;
			DontDestroyOnLoad(gameObject);
		}
		else
			Destroy(gameObject);
	}

	void OnEnable()
	{
		SceneManager.sceneLoaded += OnLevelFinishedLoading;
	}

	void OnDisable()
	{
		SceneManager.sceneLoaded -= OnLevelFinishedLoading;
	}
	#endregion

	#region Public Methods


	#endregion

	#region Private Methods

	void OnLevelFinishedLoading(Scene scene, LoadSceneMode mode)
	{
		if (scene.name == "Game")
		{
			Instantiate(_players[_playerIndex]);
		}
	}
	#endregion
}
