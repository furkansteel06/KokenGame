using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger_1 : MonoBehaviour
{
    public Dialogue dialogue1;

    public void TriggerDialogue1()
    {
        FindObjectOfType<DialogueManager_1>().StartDialogue1(dialogue1);
    }
}
