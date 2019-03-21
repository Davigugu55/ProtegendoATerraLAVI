using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjetosSala : MonoBehaviour {

    public Button botao;
    public Text mensagem;
    public GameObject painel, objeto;
    bool colisor;

    void OnTriggerEnter(Collider player)
    {
        if (player.name == "Tamires")
        {
            AkSoundEngine.PostEvent("d85", gameObject);
        }
    }
    void OnTriggerStay(Collider player)
    {
        if (player.name == "Tamires")
        {
            colisor = true;
            botao.onClick.AddListener(DetectaColisao);
            mensagem.text = "Pegar";
        }
    }
    void OnTriggerExit(Collider player)
    {
        if (player.name == "Tamires")
        {
            Debug.Log("saiu");
            colisor = false;
            mensagem.text = "";
        }
    }
    void DetectaColisao()
    {
        if (colisor)
        {
            TaskOnClick();
            colisor = false;
        }
    }
    void TaskOnClick()
    {
        mensagem.text = "";
        objeto.SetActive(false);
        painel.SetActive(true);
        Debug.Log("desligou consumo");
    }
}
