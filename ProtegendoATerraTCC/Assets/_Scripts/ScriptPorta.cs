using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//using UnityEngine.AI;

public class ScriptPorta : MonoBehaviour {

	private Animator animator;
	public Button botao;

	void Start () {
		animator = GetComponent<Animator> ();
	}

	void OnTriggerStay(Collider player){
		if (player.name == "Tamires") {
			botao.onClick.AddListener (TaskOnClick);
		}
	}
	void TaskOnClick()
	{
		animator.SetBool ("open", true);
		AkSoundEngine.PostEvent ("PortaAbrindo", gameObject);
	}
}