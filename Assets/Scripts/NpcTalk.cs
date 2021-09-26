using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NpcTalk : Interactable
{
    public Dialogue dialogue;
    public Dialogue dialogueEnd;
    public GameObject npcMessage;

    public override void Interact()
    {
        GameObject gm = GameObject.Find("GameManager");
        GameObject dm = GameObject.Find("DialogueManager");

        if (gm.GetComponent<GameManager>().hasItem4 == true)
        {
            Debug.Log("npc talk end");
            FindObjectOfType<DialogueManager>().StartDialogue(dialogueEnd);
            npcMessage.SetActive(false);

            if (dialogueEnd.name == "Momma Bear" && gm.GetComponent<GameManager>().bearTalk == false)
            {
                gm.GetComponent<GameManager>().finalChatCount += 1;
                Debug.Log( gm.GetComponent<GameManager>().finalChatCount);
                gm.GetComponent<GameManager>().bearTalk = true;
            }
            if (dialogueEnd.name == "Man in a chicken suit" && gm.GetComponent<GameManager>().chickenTalk == false)
            {
                gm.GetComponent<GameManager>().finalChatCount += 1;
                Debug.Log( gm.GetComponent<GameManager>().finalChatCount);
                gm.GetComponent<GameManager>().chickenTalk = true;
            }
            if (dialogueEnd.name == "Flower" && gm.GetComponent<GameManager>().flowerTalk == false)
            {
                gm.GetComponent<GameManager>().finalChatCount += 1;
                Debug.Log(gm.GetComponent<GameManager>().finalChatCount);
                gm.GetComponent<GameManager>().flowerTalk = true;
            }
            if (dialogueEnd.name == "ref(robot_name)" && gm.GetComponent<GameManager>().robotTalk == false)
            {
                gm.GetComponent<GameManager>().finalChatCount += 1;
                Debug.Log( gm.GetComponent<GameManager>().finalChatCount);
                gm.GetComponent<GameManager>().robotTalk = true;
            }
            if (dialogueEnd.name == "Blurg" && gm.GetComponent<GameManager>().alienTalk == false)
            {
                gm.GetComponent<GameManager>().finalChatCount += 1;
                Debug.Log( gm.GetComponent<GameManager>().finalChatCount);
                gm.GetComponent<GameManager>().alienTalk = true;
            }
            if (dialogueEnd.name == "Gary" && gm.GetComponent<GameManager>().fatTalk == false)
            {
                gm.GetComponent<GameManager>().finalChatCount += 1;
                Debug.Log( gm.GetComponent<GameManager>().finalChatCount);
                gm.GetComponent<GameManager>().fatTalk = true;
            }
            if (dialogueEnd.name == "Russel" && gm.GetComponent<GameManager>().bigTalk == false)
            {
                gm.GetComponent<GameManager>().finalChatCount += 1;
                Debug.Log( gm.GetComponent<GameManager>().finalChatCount);
                gm.GetComponent<GameManager>().bigTalk = true;
            }
            if (dialogueEnd.name == "Farmer Joe" && gm.GetComponent<GameManager>().farmerTalk == false)
            {
                gm.GetComponent<GameManager>().finalChatCount += 1;
                Debug.Log( gm.GetComponent<GameManager>().finalChatCount);
                gm.GetComponent<GameManager>().farmerTalk = true;
            }
            if (dialogueEnd.name == "Queen" && gm.GetComponent<GameManager>().queenTalk == false)
            {
                gm.GetComponent<GameManager>().finalChatCount += 1;
                Debug.Log( gm.GetComponent<GameManager>().finalChatCount);
                gm.GetComponent<GameManager>().queenTalk = true;
            }
        }

        else
        {
            Debug.Log("npc talk");
            FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
            npcMessage.SetActive(false);
        }
        
    }
}
