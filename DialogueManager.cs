using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// 实现原理 通过开启GameObject 的 SetActive来达到预想效果

public class DialogueManager : MonoBehaviour
{
    public Text NameText;
    public Text DialogueText;
    public GameObject StartConversation;
    public GameObject NextConversation;
    public GameObject Charatering;
    public GameObject BackGround;
    
    private Queue<string> sentences; // 记句子

    private void Start()
    {
        sentences = new Queue<string>();
        // 开启开场对话， 默认为Null
        if (StartConversation !=null)
        {
            StartConversation.GetComponent<DialogueTrigger>().TriggerMnager();
        }
    }

    public void StartDialogue(Dialogue dialogue)
    {
        if (dialogue.NextConversation != null)
        {
            NextConversation = dialogue.NextConversation;
        }
        else
        {
            NextConversation = null; //清空
        }

        if (dialogue.CharaterImage!=null)
        {
            Charatering = dialogue.CharaterImage;
            Charatering.SetActive(true);
        }

        NameText.text = dialogue.name;
        DialogueText.fontSize = dialogue.fontSize;
        sentences.Clear();
        // 显示对话
        foreach (string senten in dialogue.sentens)
        {
            sentences.Enqueue(senten);
        }

        A_DisplayNextSentence();
    }


    public void A_DisplayNextSentence()
    {
        if (sentences.Count ==0)
        {
            EndDialogue();
            return;
        }

        string sentence = this.sentences.Dequeue();
        DialogueText.text = sentence;  
        StopAllCoroutines();
        StartCoroutine(TypeSentence(sentence));
    }

    IEnumerator TypeSentence(string sentence)
    {
        DialogueText.text = "";
        foreach (char letter in sentence.ToCharArray())
        {
            DialogueText.text += letter;
            yield return new WaitForSeconds(0.04f); 
        }

        yield return null;

    }

    public void EndDialogue()
    {
        
        if (Charatering != null)
        {
            Debug.Log("关闭人物图像 BackGround");
            Charatering.SetActive(false);
        }

        if (BackGround!=null)
        {
            Debug.Log("关闭背景 BackGround");
            BackGround.SetActive(false);
        }
        if (NextConversation != null)
        {
            NextConversation.GetComponent<DialogueTrigger>().TriggerMnager();
        }
        else
        {
            DialogueText.text = "";
        }

    }

}
