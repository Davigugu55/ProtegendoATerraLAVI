using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColetaSinos : MonoBehaviour {

    public GameObject s1, s2, s3, s4, caminho, controle;
    bool trava = true;

	// Update is called once per frame
	void Update () {
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
            AkSoundEngine.PostEvent("ParaTudo", gameObject);
            AkSoundEngine.PostEvent("d77", gameObject);
        }
    }
}
