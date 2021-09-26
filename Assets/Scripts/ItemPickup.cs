using UnityEngine;

public class ItemPickup : Interactable
{
    public Item item;
    public Dialogue dialogue;
    public Dialogue dialogueWeak;
    int dialogueWait = 3;
    public PlayerManager playerManager;
    public override void Interact()
    {
        //base.Interact();

        PickUp();
    }

    void PickUp()
    {
        GameObject gm = GameObject.Find("GameManager");
        GameObject pm = GameObject.Find("Player");
        

        Debug.Log("Picking up " + item.name);        

        if (gameObject.tag == "Item_1")
        {
            if (pm.GetComponent<PlayerManager>().currentStrength == 20)
            {
                gm.GetComponent<GameManager>().hasItem1 = true;
                pm.GetComponent<PlayerManager>().GainStrength(10);

                Inventory.instance.Add(item);
                FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
                
                Destroy(gameObject);

            }
            else
            {
                FindObjectOfType<DialogueManager>().StartDialogue(dialogueWeak);
            }
        }

        if (gameObject.tag == "Item_2")
        {
            if (pm.GetComponent<PlayerManager>().currentStrength == 30)
            {
                gm.GetComponent<GameManager>().hasItem2 = true;
                pm.GetComponent<PlayerManager>().GainStrength(10);

                Inventory.instance.Add(item);
                FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
                
                Destroy(gameObject);

            }

            else
            {
                FindObjectOfType<DialogueManager>().StartDialogue(dialogueWeak);
            }
            
        }

        if (gameObject.tag == "Item_3")
        {
            if (pm.GetComponent<PlayerManager>().currentStrength == 40)
            {
                gm.GetComponent<GameManager>().hasItem3 = true;
                pm.GetComponent<PlayerManager>().GainStrength(20);

                Inventory.instance.Add(item);
                FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
                
                Destroy(gameObject);

            }

            else
            {
                FindObjectOfType<DialogueManager>().StartDialogue(dialogueWeak);
            }
            
        }

        if (gameObject.tag == "Item_4")
        {
            if (pm.GetComponent<PlayerManager>().currentStrength == 60)
            {
                gm.GetComponent<GameManager>().hasItem4 = true;
                pm.GetComponent<PlayerManager>().GainStrength(20);

                Inventory.instance.Add(item);
                FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
                
                Destroy(gameObject);

                GameObject bear = GameObject.Find("Bear");
                GameObject flower = GameObject.Find("flower");
                GameObject chickenBoy = GameObject.Find("ChickenBoy");
                GameObject robot = GameObject.Find("robot");
                GameObject alien = GameObject.Find("alien");
                GameObject bigguy = GameObject.Find("bigguy");
                GameObject fatguy = GameObject.Find("fatguy");
                GameObject farmer = GameObject.Find("farmer");
                GameObject queen = GameObject.Find("queen");

                bear.transform.position = new Vector3 (-2.25f ,4.95f ,0);
                bear.GetComponent<NpcTalk>().npcMessage.SetActive(true);

                flower.transform.position = new Vector3 (-2.88f ,-0.13f ,0);
                flower.GetComponent<Interactable>().radius = 1f;
                flower.GetComponent<NpcTalk>().npcMessage.SetActive(true);

                chickenBoy.transform.position = new Vector3 (1.01f ,0.06f ,0);
                chickenBoy.GetComponent<Interactable>().radius = 1f;
                chickenBoy.GetComponent<NpcTalk>().npcMessage.SetActive(true);

                robot.transform.position = new Vector3 (0.99f ,-3.18f ,0);
                robot.GetComponent<Interactable>().radius = 1f;
                robot.GetComponent<NpcTalk>().npcMessage.SetActive(true);

                alien.transform.position = new Vector3 (-2.8f ,-3.12f ,0);
                alien.GetComponent<Interactable>().radius = 1f;
                alien.GetComponent<NpcTalk>().npcMessage.SetActive(true);

                bigguy.transform.position = new Vector3 (0.97f ,1.83f ,0);
                bigguy.GetComponent<Interactable>().radius = 1.5f;
                bigguy.GetComponent<NpcTalk>().npcMessage.SetActive(true);

                fatguy.transform.position = new Vector3 (-2.83f ,-1.56f ,0);
                fatguy.GetComponent<Interactable>().radius = 1.5f;
                fatguy.GetComponent<NpcTalk>().npcMessage.SetActive(true);

                farmer.transform.position = new Vector3 (-2.9f ,1.4f ,0);
                farmer.GetComponent<Interactable>().radius = 1f;
                farmer.GetComponent<NpcTalk>().npcMessage.SetActive(true);

                queen.transform.position = new Vector3 (1.07f ,-1.47f ,0);
                queen.GetComponent<Interactable>().radius = 1f;
                queen.GetComponent<NpcTalk>().npcMessage.SetActive(true);

                gm.GetComponent<GameManager>().WaitEndingDinner();
                
            }

            else
            {
                FindObjectOfType<DialogueManager>().StartDialogue(dialogueWeak);
            }
        }
    }
}
