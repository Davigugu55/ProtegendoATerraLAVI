using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class MovimentacaoPersonagem : MonoBehaviour {

	public float dirX;
	bool andando;
	// Use this for initialization
	void Start () {
		Input.gyro.enabled = true;
		andando = false;
	}
	
	// Update is called once per frame
	void Update () {
		dirX = CrossPlatformInputManager.GetAxis ("Vertical");
		if (dirX != 0) {
			if (andando) {
				AkSoundEngine.PostEvent ("Footstep", gameObject);
			}
			andando = false;
			transform.Translate (0, 0, dirX * Time.deltaTime);
		} else {
			if (! andando) {
				AkSoundEngine.PostEvent ("ParaFootstep", gameObject);
			}
			andando = true;
		}
		//transform.Translate (Input.GetAxis("Horizontal") * Time.deltaTime, 0, Input.GetAxis("Vertical") * Time.deltaTime);
		transform.Rotate (0, -Input.gyro.rotationRateUnbiased.y * 3,0);
	}

}