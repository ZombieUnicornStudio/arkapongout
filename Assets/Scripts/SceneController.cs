﻿using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour {

	public void LoadNext () {
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
	}

}