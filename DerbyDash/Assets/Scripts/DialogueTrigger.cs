using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    public GameObject startConversationButton;

    public Dialogue dialogue;

    //DialogueManager _dialogueManager;

    //NEW 10/03/2023
    public Dialogue dialogueTwo;

    public void TriggerDialogue ()
    {
        FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
    }

    //NEW 10/03/2023
    public void TriggerDialogueTwo()
    {
        FindObjectOfType<DialogueManager>().StartDialogueTwo(dialogueTwo);
    }
}
