using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//using UnityEngine.AI;

public class ScriptPorta : MonoBehaviour {

	private Animator animator;
	public Button botao;
	bool colisor;
	public Text mensagem;

	void Start () {
		animator = GetComponent<Animator> ();
	}

	void OnTriggerEnter(Collider player){
		if (player.name == "Tamires") {
			mensagem.text = "Abrir";
			Debug.Log ("entrou");
			colisor = true;
			botao.onClick.AddListener (DetectaColisao);
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
		AkSoundEngine.PostEvent ("PortaAbrindo", gameObject);
        AkSoundEngine.PostEvent("interacao", gameObject);
        animator.SetBool ("open", true);
		Debug.Log ("porta abriu");
	}
}