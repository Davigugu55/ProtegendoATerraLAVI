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
		player.transform.Rotate (-Input.gyro.rotationRateUnbiased.x, -Input.gyro.rotationRateUnbiased.y,-Input.gyro.rotationRateUnbiased.z);
		//player.transform.RotateAround(-Input.gyro.rotationRateUnbiased.x, -Input.gyro.rotationRateUnbiased.y,-Input.gyro.rotationRateUnbiased.z);
	}
}
