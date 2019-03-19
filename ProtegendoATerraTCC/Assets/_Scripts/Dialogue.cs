using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dialogue : MonoBehaviour
{
    public Text CaixaTexto;
    public GameObject controle;
    public GameObject pLegenda;
    public GameObject trigger;
    public GameObject caminhos;
    public Button botao;
    public string tela;
    bool colisor;
    public GameObject[] mobilias;
    public string[] dialogo, dublagem;
    private Queue<string> sentences;
    int indice = 0;
    
    private void Start()
    {
        sentences = new Queue<string>();
        if (mobilias != null)
        {
            foreach(GameObject mobilia in mobilias)
            {
                mobilia.SetActive(true);
            }
        }
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

    void OnTriggerStay(Collider player)
    {
        if (player.name == "Tamires")
        {
            //Debug.Log("entrou");
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
        ProxDialogo();
        //Debug.Log("Prox dialogo");
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
   
    void EndDialogue()
    {
        indice = 0;
        AkSoundEngine.PostEvent("ParaTudo", gameObject);
        AkSoundEngine.PostEvent(tela, gameObject);
        //Debug.Log("porra");
        pLegenda.SetActive(false);
        trigger.SetActive(false);
        caminhos.SetActive(true);
    }
}