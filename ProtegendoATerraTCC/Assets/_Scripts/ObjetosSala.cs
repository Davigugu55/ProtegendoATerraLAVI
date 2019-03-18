using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjetosSala : MonoBehaviour {

    public Button botao;
    bool colisor;
    public Text mensagem;

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
        Debug.Log("desligou consumo");
    }
}
