using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour {
	
	public GameObject pauseMenuUI;

	public void resume(){
		Time.timeScale = 1f;
	}
	public void pause(){
		Time.timeScale = 0f;
	}
}