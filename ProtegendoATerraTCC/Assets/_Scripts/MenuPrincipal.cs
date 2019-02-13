using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuPrincipal : MonoBehaviour {

	public void IniciarJogo(){
		SceneManager.LoadScene (1);
	}
	public void SairJogo(){
		Debug.Log ("Sair");
		Application.Quit ();
	}
	public void Creditos(){
		SceneManager.LoadScene (2);
	}
	public void RetornaMenuPrincipal(){
		SceneManager.LoadScene (0);
	}
}