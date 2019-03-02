using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dialogue : MonoBehaviour
{
    public Text CaixaTexto;
    public string[] sentences;
    //private int index;

    private void Start()
    {
        StartCoroutine(dialogo());
    }
    IEnumerator dialogo()
    {
        foreach(string sentence in sentences)
        {
            Debug.Log(sentence);
            CaixaTexto.text = sentence;
            yield return new WaitForSeconds(5);
        }
    }
}