using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChargeVolumeLevels: MonoBehaviour {

	public Slider thisSlider;
	public float geralVolume;
	public float dublagemVolume;
	public float musicaVolume;
	public float ambienteVolume;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void SetSpecificVolume(string whatValue){
		float sliderValue = thisSlider.value;

		if (whatValue == "Geral") {
			geralVolume = thisSlider.value;
			AkSoundEngine.SetRTPCValue ("GeralVolume", geralVolume);
		}

		if (whatValue == "Musica") {
			musicaVolume = thisSlider.value;
			AkSoundEngine.SetRTPCValue ("MusicaVolume", musicaVolume);
		}

		if (whatValue == "Dublagem") {
			dublagemVolume = thisSlider.value;
			AkSoundEngine.SetRTPCValue ("DublagemVolume", dublagemVolume);
		}

		if (whatValue == "Ambiente") {
			ambienteVolume = thisSlider.value;
			AkSoundEngine.SetRTPCValue ("AmbienteVolume", ambienteVolume);
		}
	}
}
