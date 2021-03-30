using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameplayUIController : MonoBehaviour
{
	#region Fields & Properties

	[SerializeField] GameObject _restartButton, _homeButton;

	#endregion

	#region Getters


	#endregion

	#region Unity Methods

	void OnEnable()
	{
		Player.PlayerDied += OnPlayerDied;
	}

	void OnDisable()
	{
		Player.PlayerDied -= OnPlayerDied;
	}

	void Awake()
	{
		Time.timeScale = 1f;
	}
	#endregion

	#region Public Methods

	public void RestartGame()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().name);
	}

	public void MainMenu()
	{
		SceneManager.LoadScene("Main Menu");
	}
	#endregion

	#region Private Methods

	void OnPlayerDied()
	{
		_restartButton.SetActive(true);
		_homeButton.SetActive(true);
		Time.timeScale = 0f;
	}
	#endregion
}
