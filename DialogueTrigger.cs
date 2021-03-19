using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DialogueTrigger : MonoBehaviour
{
   public Dialogue _dialogue;
   public void TriggerMnager()
   {
      FindObjectOfType<DialogueManager>().StartDialogue(_dialogue);
   }
}
