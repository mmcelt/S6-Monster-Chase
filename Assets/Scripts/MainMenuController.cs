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
		
	}
	
	void Update() 
	{
		
	}
	#endregion

	#region Public Methods

	public void PlayGame()
	{
		SceneManager.LoadScene("Game");
	}
	#endregion

	#region Private Methods


	#endregion
}
