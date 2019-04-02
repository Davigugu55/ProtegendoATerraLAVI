using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IaMonstroLixo : MonoBehaviour {
    public Transform t1,t2,t3,t4;
    UnityEngine.AI.NavMeshAgent agent;
    public Button botao;
    public GameObject monstro,t101,butao;
    bool colisor;

    void Start()
    {
        agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
        AkSoundEngine.PostEvent("MonstroLixo", gameObject);
    }

    void OnTriggerStay(Collider player)
    {
        if (player.name == "Tamires")
        {
            //Debug.Log("Tamires entrou monstro");
            colisor = true;
            botao.onClick.AddListener(DetectaColisao);
        }
    }
    void OnTriggerExit(Collider player)
    {
        if (player.name == "Tamires")
        {
            //Debug.Log("saiu");
            colisor = false;
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
        AkSoundEngine.PostEvent("interacao", gameObject);
        Debug.Log("morreu monstro");
        t101.SetActive(true);
        monstro.SetActive(false);
        butao.SetActive(false);
        t101.SetActive(true);
    }

    void OnTriggerEnter(Collider player)
    {
        if (player.name == "Tamires")
        {
            AkSoundEngine.PostEvent("ParaTudo", gameObject);
            AkSoundEngine.PostEvent("d82", gameObject);
        }
        if (player.name == "tm1")
        {
            //Debug.Log("entrou monstro");
            agent.destination = t2.position;
        }
        if (player.name == "tm2")
        {
            //Debug.Log("entrou monstro");
            agent.destination = t3.position;
        }
        if (player.name == "tm3")
        {
            //Debug.Log("entrou monstro");
            agent.destination = t4.position;
        }
        if (player.name == "tm4")
        {
            //Debug.Log("entrou monstro");
            agent.destination = t1.position;
        }
    }
}
