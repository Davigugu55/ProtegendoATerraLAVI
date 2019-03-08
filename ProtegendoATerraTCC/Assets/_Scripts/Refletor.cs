using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Refletor : MonoBehaviour {
    public GameObject refletor;

    void OnTriggerEnter(Collider player)
    {
        if (player.name == "Tamires")
        {
            AtivaRefletor();
        }
    }

    public void AtivaRefletor()
    {
        refletor.SetActive(true);
    }
    public void DesativaRefletor()
    {
        refletor.SetActive(false);
    }
}
