using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TutorialSinos : MonoBehaviour {

    public Button botao;
    bool colisor;
    public GameObject sino, psino;
    //public Text mensagem;

    void Start()
    {

    }

    void OnTriggerEnter(Collider player)
    {
        if (player.name == "Cacetinho")
        {
            //mensagem.text = "Abrir";
            Debug.Log("entrou");
            colisor = true;
            botao.onClick.AddListener(DetectaColisao);
        }
    }
    void OnTriggerExit(Collider player)
    {
        if (player.name == "Cacetinho")
        {
            Debug.Log("saiu");
            colisor = false;
            //mensagem.text = "";
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
        AkSoundEngine.PostEvent("ParaTudo", gameObject);
        Debug.Log("desligou sino");
        psino.SetActive(true);
        sino.SetActive(false);
    }
}
