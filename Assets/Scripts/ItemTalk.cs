using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemTalk : Interactable
{
    public Dialogue dialogue;
    public override void Interact()
    {
        Debug.Log("npc talk");
        //FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
        //npcMessage.SetActive(false);
    }
}
