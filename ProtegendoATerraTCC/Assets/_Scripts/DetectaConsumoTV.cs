using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DetectaConsumoTV : MonoBehaviour {

	public Button botao;
	public GameObject luz;
	bool colisor;
	bool liga = true;

	void OnTriggerStay(Collider player){
		if (player.name == "Tamires") {
			Debug.Log ("entrou");
			colisor = true;
			botao.onClick.AddListener (DetectaColisao);
		}
	}
	void OnTriggerExit(Collider player){
		if (player.name == "Tamires") {
			Debug.Log ("saiu");
			colisor = false;
		}
	}
	void DetectaColisao(){
		if (colisor) {
			TaskOnClick ();
			colisor = false;
		}
	}
	void TaskOnClick()
	{
		if (liga) {
			luz.SetActive (false);
			AkSoundEngine.PostEvent ("ParaTV", gameObject);
			liga = false;
		} else {
			luz.SetActive (true);
			AkSoundEngine.PostEvent ("TV", gameObject);
			liga = true;
		}
		Debug.Log ("desligou consumo");
	}
}