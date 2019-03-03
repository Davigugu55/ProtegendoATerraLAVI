using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dialogue : MonoBehaviour
{
    public Text CaixaTexto;
    public GameObject controle;
    public GameObject pLegenda;
    public string[] dialogo;
    private Queue<string> sentences;
    
    private void Start()
    {
        sentences = new Queue<string>();
    }

    void OnTriggerEnter(Collider player)
    {
        if (player.name == "Tamires")
        {
            pLegenda.SetActive(true);
            controle.SetActive(false);
            StartDialogue();
        }
    }

    public void StartDialogue()
    {
        sentences.Clear();

        foreach (string sentence in dialogo)
        {
            sentences.Enqueue(sentence);
        }

        ProxDialogo();
    }

    public void ProxDialogo()
    {
        if (sentences.Count == 0)
        {
            EndDialogue();
            return;
        }

        string sentence = sentences.Dequeue();
        StopAllCoroutines();
        StartCoroutine(TypeSentence(sentence));
    }

    IEnumerator TypeSentence(string sentence)
    {
        CaixaTexto.text = "";
        foreach (char letter in sentence.ToCharArray())
        {
            CaixaTexto.text += letter;
            yield return null;
        }
    }
   
    void EndDialogue()
    {
        Debug.Log("porra");
        controle.SetActive(true);
        pLegenda.SetActive(false);
    }
}