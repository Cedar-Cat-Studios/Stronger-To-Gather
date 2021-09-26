using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class DialogueEnd
{
    public string name; //npc name
    [TextArea(3,10)]
    public string[] sentences;
}