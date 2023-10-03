using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueAnimator : MonoBehaviour
{
    public Animator animator;
    public Text dialogueText;
    public Text nameText;
    private void Start()
    {
        Time.timeScale = 1f;
    }
    void OnEnable()
    {
        DialogueManager.OnDialogueOpen += SetDialogueOpen;
        DialogueManager.OnDialogueText += SetDialogueText;
        DialogueManager.OnDialogueName += SetDialogueNameText;
        //I am gonna go on an adventure :D
    }

    void OnDisable()
    {
        DialogueManager.OnDialogueOpen -= SetDialogueOpen;
        DialogueManager.OnDialogueText -= SetDialogueText;
        DialogueManager.OnDialogueName -= SetDialogueNameText;
    }

    void SetDialogueOpen(bool value)
    {
        animator.SetBool("IsOpen", value);
    }

    void SetDialogueText(string value)
    {
        dialogueText.text = value; 
    }

    void SetDialogueNameText(string value)
    {
        nameText.text = value;
    }
}
