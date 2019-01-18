using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class MovimentacaoPersonagem : MonoBehaviour {

	float dirX;
	// Use this for initialization
	void Start () {
		Input.gyro.enabled = true;
	}
	
	// Update is called once per frame
	void Update () {
		dirX = CrossPlatformInputManager.GetAxis ("Vertical");
		transform.Translate (0, 0, dirX * Time.deltaTime);
		transform.Rotate (0, -Input.gyro.rotationRateUnbiased.y, 0);
	}
}
