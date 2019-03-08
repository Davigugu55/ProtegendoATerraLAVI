using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTamires : MonoBehaviour {
    public Transform t1,t2,t3,t4,t5,t6,t7,t8,t9,t10,tTutorial,ttuto,refletor;
    public GameObject s1, s2, s3, s4, caminho, controle;
    UnityEngine.AI.NavMeshAgent agent;
    bool trava = true;

    void Start () {
        agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
        //m2();
    }
    private void Update()
    {
        if (trava)
        {
            Verifica();
        }
    }
    public void Verifica()
    {
        if (s1.activeSelf != true && s2.activeSelf != true && s3.activeSelf != true && s4.activeSelf != true)
        {
            caminho.SetActive(true);
            controle.SetActive(false);
            trava = false;
        }
    }
    public void M1()
    {
        agent.destination = t1.position;
    }
    public void M2()
    {
        agent.destination = t2.position;
    }
    public void M3()
    {
        agent.destination = t3.position;
    }
    public void M4()
    {
        agent.destination = t4.position;
    }
    public void M5()
    {
        agent.destination = t5.position;
    }
    public void M6()
    {
        agent.destination = t6.position;
    }
    public void M7()
    {
        agent.destination = t7.position;
    }
    public void M8()
    {
        agent.destination = t8.position;
    }
    public void M9()
    {
        agent.destination = t9.position;
    }
    public void M10()
    {
        agent.destination = t10.position;
    }
    public void MTutorial()
    {
        agent.destination = tTutorial.position;
    }
    public void Mtuto()
    {
        agent.destination = ttuto.position;
    }
    public void Mrefletor()
    {
        agent.destination = refletor.position;
    }
    public void Para()
    {
        agent.isStopped=true;
    }
    public void Volta()
    {
        agent.isStopped = true;
    }
}