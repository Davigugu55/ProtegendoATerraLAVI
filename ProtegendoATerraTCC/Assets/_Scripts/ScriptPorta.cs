using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//using UnityEngine.AI;

public class ScriptPorta : MonoBehaviour {

	private Animator animator;
	public Button botao;
	//public NavMeshSurface surface;

	void Start () {
		animator = GetComponent<Animator> ();
	}

	void OnTriggerEnter(Collider other){
		botao.onClick.AddListener(TaskOnClick);
	}
	void TaskOnClick()
	{
		animator.SetBool ("open", true);
		//surface.BuildNavMesh ();
		Debug.Log("You have clicked the button!");
	}
}
