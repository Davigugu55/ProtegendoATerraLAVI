using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IaMonstroLixo : MonoBehaviour {
    public Transform t1,t2,t3,t4;
    UnityEngine.AI.NavMeshAgent agent;

    void Start()
    {
        agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
        AkSoundEngine.PostEvent("MonstroLixo", gameObject);
    }

    public void SomMonstro()
    {
        Debug.Log("Som Monstro");
        //AkSoundEngine.PostEvent("MonstroLixo", gameObject);
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
