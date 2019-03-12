using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InterruptorRefletor : MonoBehaviour {

	public Button botao;
	bool colisor;
	public Text mensagem;

    void OnTriggerStay(Collider player){
		if (player.name == "Tamires") {
			colisor = true;
            mensagem.text = "Desligar";
            botao.onClick.AddListener (DetectaColisao);
		}
	}
	void OnTriggerExit(Collider player){
		if (player.name == "Tamires") {
			mensagem.text = "";
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
		AkSoundEngine.PostEvent ("DesligaInterruptor", gameObject);
        AkSoundEngine.PostEvent("interacao", gameObject);
    }
}
