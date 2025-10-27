using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueControl : MonoBehaviour
{

    [Header("Components")]
    public GameObject dialogueObj;//janela do diálogo
    public Image profileSprite;//sprite do perfil
    public Text spechText;//texto da fala
    public Text actorNameText;//Nome do NPC

    [Header("Settings")]
    public float typingSpeed;//velocidade da fala


    //Variáveis de controle
    private bool isShowing;//se a janela está visível
    private int index;//Rodar os laços de repetição(Basicamente ele será utilizado para saber quantas falas estão sendo ditas até ser encerrado)
    private string[] sentences;

    void Start()
    {
        
    }

    void Update()
    {
        
    }


    IEnumerator TypeSentence()
    {
        foreach (char letter in sentences[index].ToCharArray())
        {
            spechText.text += letter;//Vai ser feito a alimentação de letra por letra no diálogo
            yield return new WaitForSeconds(typingSpeed);
        }
    }

    //Pular para a próxima  fase/fala
    public void NextSentences()
    {

    }

    //chamar a fala do npc
    public void Speech(string[] txt)
    {
        if (!isShowing)
        {
            dialogueObj.SetActive(true);
            sentences = txt;
            StartCoroutine(TypeSentence());
            isShowing = true;
        }
    }
}
