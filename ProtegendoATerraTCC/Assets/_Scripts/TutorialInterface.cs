using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TutorialInterface : MonoBehaviour
{
    public Text CaixaTexto;
    public GameObject controle, caminhos, caixaD;
    public string[] dialogo, dublagem;
    private Queue<string> sentences;
    int indice = 0;

    private void Start()
    {
        sentences = new Queue<string>();
        StartDialogue();
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

        AkSoundEngine.PostEvent("ParaTudo", gameObject);
        AkSoundEngine.PostEvent(dublagem[indice], gameObject);
        indice = indice + 1;

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

    public void D72()
    {
        AkSoundEngine.PostEvent("ParaTudo", gameObject);
        AkSoundEngine.PostEvent("d72", gameObject);
    }
    public void D73()
    {
        AkSoundEngine.PostEvent("ParaTudo", gameObject);
        AkSoundEngine.PostEvent("d73", gameObject);
    }
    public void D74()
    {
        AkSoundEngine.PostEvent("ParaTudo", gameObject);
        AkSoundEngine.PostEvent("d74", gameObject);
    }
    public void D75()
    {
        AkSoundEngine.PostEvent("ParaTudo", gameObject);
        AkSoundEngine.PostEvent("d75", gameObject);
    }
    public void D76()
    {
        AkSoundEngine.PostEvent("ParaTudo", gameObject);
        AkSoundEngine.PostEvent("d76", gameObject);
    }
    public void D77()
    {
        AkSoundEngine.PostEvent("ParaTudo", gameObject);
        AkSoundEngine.PostEvent("d77", gameObject);
    }
    void EndDialogue()
    {
        indice = 0;
        AkSoundEngine.PostEvent("ParaTudo", gameObject);
        AkSoundEngine.PostEvent("d71", gameObject);
        caminhos.SetActive(true);
        caixaD.SetActive(false);
    }
}