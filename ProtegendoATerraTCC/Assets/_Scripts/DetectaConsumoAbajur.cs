using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class DetectaConsumoAbajur : MonoBehaviour {

	public Button botao;
	bool colisor;
	public GameObject luz;
	bool liga = true;
	public Text mensagem;

	void OnTriggerStay(Collider player){
		if (player.name == "Tamires") {
			Debug.Log ("entrou");
			colisor = true;
			botao.onClick.AddListener (DetectaColisao);
			if (liga) {
				mensagem.text = "Desligar";
			} else {
				mensagem.text = "Ligar";
			}
		}
	}
	void OnTriggerExit(Collider player){
		if (player.name == "Tamires") {
			Debug.Log ("saiu");
			colisor = false;
			mensagem.text = "";
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
			AkSoundEngine.PostEvent ("ParaLampadaEletronica", gameObject);
            AkSoundEngine.PostEvent("interacao", gameObject);
            liga = false;
		} else {
			luz.SetActive (true);
			AkSoundEngine.PostEvent ("LampadaEletronica", gameObject);
            AkSoundEngine.PostEvent("interacao", gameObject);
            liga = true;
		}
	}
}
