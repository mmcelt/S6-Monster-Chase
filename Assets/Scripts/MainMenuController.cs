using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
	#region Fields & Properties


	#endregion

	#region Getters


	#endregion

	#region Unity Methods

	void Start() 
	{
		Time.timeScale = 1f;
	}
	#endregion

	#region Public Methods

	public void PlayGame()
	{
		int selectedPlayer = int.Parse(UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.name);

		GameManager.Instance.PlayerIndex = selectedPlayer;

		SceneManager.LoadScene("Game");
	}
	#endregion

	#region Private Methods

	#endregion
}
