using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTamires : MonoBehaviour {
    public Transform t1,t2,t21,t3,t31,t4,t41,t5,t51,t6,t61,t7,t71,t8,t81,t9,t91,t10,t101,refletor,monstro,ob1,ob2,ob3,ob4,ob5;
    public GameObject monstrot;
    UnityEngine.AI.NavMeshAgent agent;
    bool trava = true;
    bool monster = false;
    bool walk = false;

    void Start () {
        agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
        //m2();
    }
    private void Update()
    {
        if (agent.remainingDistance != 0)
        {
            if (!walk)
            {
                walk = true;
                AkSoundEngine.PostEvent("Footstep", gameObject);
            }
        }
        if (agent.remainingDistance == 0)
        {
            if (walk)
            {
                walk = false;
                AkSoundEngine.PostEvent("ParaTudo", gameObject);
            }
        }
        if (monstrot.activeSelf)
        {
            agent.destination = monstro.position;
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
    public void M21()
    {
        agent.destination = t21.position;
    }
    public void M3()
    {
        agent.destination = t3.position;
    }
    public void M31()
    {
        agent.destination = t31.position;
    }
    public void M4()
    {
        agent.destination = t4.position;
    }
    public void M41()
    {
        agent.destination = t41.position;
    }
    public void M5()
    {
        agent.destination = t5.position;
    }
    public void M51()
    {
        agent.destination = t51.position;
    }
    public void M6()
    {
        agent.destination = t6.position;
    }
    public void M61()
    {
        agent.destination = t61.position;
    }
    public void M7()
    {
        agent.destination = t7.position;
    }
    public void M71()
    {
        agent.destination = t71.position;
    }
    public void M8()
    {
        agent.destination = t8.position;
    }
    public void M81()
    {
        agent.destination = t81.position;
    }
    public void M9()
    {
        agent.destination = t9.position;
    }
    public void M91()
    {
        agent.destination = t91.position;
    }
    public void M10()
    {
        agent.destination = t10.position;
    }
    public void M101()
    {
        agent.destination = t101.position;
    }
    public void Mrefletor()
    {
        agent.destination = refletor.position;
    }
    public void Mob1()
    {
        agent.destination = ob1.position;
    }
    public void Mob2()
    {
        agent.destination = ob2.position;
    }
    public void Mob3()
    {
        agent.destination = ob3.position;
    }
    public void Mob4()
    {
        agent.destination = ob4.position;
    }
    public void Mob5()
    {
        agent.destination = ob5.position;
    }
    public void Para()
    {
        agent.isStopped = true;
    }
    public void Volta()
    {
        agent.isStopped = false;
    }
}