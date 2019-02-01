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

	void OnTriggerEnter(Collider player){
		if (player.name == "Tamires") {
			Debug.Log (player.name);
			botao.onClick.AddListener (TaskOnClick);
		}
	}
	public void TaskOnClick()
	{
		animator.SetBool ("open", true);
	}
}
