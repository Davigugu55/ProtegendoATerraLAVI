using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Refletor : MonoBehaviour {
    public GameObject refletor;
    bool one = true;

    void OnTriggerEnter(Collider player)
    {
        if (player.name == "Tamires" && one)
        {
            AtivaRefletor();
            one = false;
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
