using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class GyroController : MonoBehaviour {

	public GameObject player;

	void Start () 
	{
		Input.gyro.enabled = true;
	}

	void Update () 
	{
		player.transform.Rotate (0, -Input.gyro.rotationRateUnbiased.y, 0);
	}
}