using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IaMonstroLixo : MonoBehaviour {
    public Transform t1,t2,t3,t4;
    UnityEngine.AI.NavMeshAgent agent;
    public Button botao;
    bool colisor;
    bool liga = true;
    public Text mensagem;

    void Start()
    {
        agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
        AkSoundEngine.PostEvent("MonstroLixo", gameObject);
    }

    void OnTriggerStay(Collider player)
    {
        if (player.name == "Tamires")
        {
            Debug.Log("entrou");
            colisor = true;
            botao.onClick.AddListener(DetectaColisao);
            if (liga)
            {
                mensagem.text = "Desligar";
            }
            else
            {
                mensagem.text = "Ligar";
            }
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
        if (liga)
        {
            //luz.SetActive (false);
            AkSoundEngine.PostEvent("ParaAguaCaindo", gameObject);
            AkSoundEngine.PostEvent("interacao", gameObject);
            liga = false;
        }
        else
        {
            //luz.SetActive (true);
            AkSoundEngine.PostEvent("AguaCaindo", gameObject);
            AkSoundEngine.PostEvent("interacao", gameObject);
            liga = true;
        }
    }
    void OnTriggerEnter(Collider player)
    {
        if (player.name == "tm1")
        {
            Debug.Log("entrou monstro");
            agent.destination = t2.position;
        }
        if (player.name == "tm2")
        {
            Debug.Log("entrou monstro");
            agent.destination = t3.position;
        }
        if (player.name == "tm3")
        {
            Debug.Log("entrou monstro");
            agent.destination = t4.position;
        }
        if (player.name == "tm4")
        {
            Debug.Log("entrou monstro");
            agent.destination = t1.position;
        }
    }
}
