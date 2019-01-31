using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.AI;

public class ScriptPorta : MonoBehaviour {

	private Animator animator;
	public Button botao;
	public NavMeshSurface[] superficie;

	void Start () {
		superficie = GetComponents<NavMeshSurface> ();
		animator = GetComponent<Animator> ();
	}
	void OnTriggerEnter(Collider other){
		botao.onClick.AddListener(TaskOnClick);
	}
	void TaskOnClick()
	{
		animator.SetBool ("open", true);
		Debug.Log("You have clicked the button!");
	}
}
