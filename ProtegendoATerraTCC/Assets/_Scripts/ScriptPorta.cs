using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//using UnityEngine.AI;

public class ScriptPorta : MonoBehaviour {

	private Animator animator;
	public Button botao;
	bool colisor;

	void Start () {
		animator = GetComponent<Animator> ();
	}

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
		AkSoundEngine.PostEvent ("PortaAbrindo", gameObject);
		Debug.Log ("porta abriu");
		animator.SetBool ("open", true);
	}
}