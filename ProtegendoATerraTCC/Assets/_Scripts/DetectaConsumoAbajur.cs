using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class DetectaConsumoAbajur : MonoBehaviour {

	public Button botao;
	bool colisor;
	public GameObject luz;

	void OnTriggerEnter(Collider player){
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
		luz.SetActive (false);
		AkSoundEngine.PostEvent ("ParaLampadaEletronica", gameObject);
		Debug.Log ("desligou consumo");
	}
}
