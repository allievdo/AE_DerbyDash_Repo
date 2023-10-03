using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

//Hello Professor Slease!!! :) How are you?
public class DialogueManager : MonoBehaviour
{
    public delegate void DialogueOpen(bool value);
    public delegate void DialogueText(string dialogueText);

    public static event DialogueText OnDialogueText;
    public static event DialogueText OnDialogueName;
    public static event DialogueOpen OnDialogueOpen;

    public Text nameText;
    public Text dialogueText;

    //NEW
    private bool raceOneEnded = false;
    private bool homeTwoStarted = false;

    private DialogueTrigger _dialogueTrigger;

    private Queue<string> sentences;

    //public static DialogueManager instance;

    //NEW
    //private void Awake()
    //{
    //    if (instance == null)
    //    {
    //        instance = this;
    //        DontDestroyOnLoad(this);
    //    }
    //    else
    //    {
    //        Destroy(this.gameObject);
    //    }
    //}

    void Start()
    {
        sentences = new Queue<string>();
    }

    public void StartDialogue (Dialogue dialogue)
    {
        Debug.Log("HELLOO???");
        OnDialogueOpen?.Invoke(true);

        OnDialogueName?.Invoke(dialogue.name);

        sentences.Clear();

        foreach (string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);
        }

        DisplayNextSentence();
    }

    public void DisplayNextSentence ()
    {
        if (sentences.Count == 0)
        {
            SceneManager.LoadScene("RaceScene");
            EndDialogue();
            //return;
        }

        string sentence = sentences.Dequeue();
        StopAllCoroutines();
        StartCoroutine(TypeSentence(sentence));
    }

    IEnumerator TypeSentence (string sentence)
    {
        string dialogueText = "";
        foreach( char letter in sentence.ToCharArray() )
        {
            dialogueText += letter;
            OnDialogueText?.Invoke(dialogueText);
            yield return null;
        }
    }

    void EndDialogue ()
    {
        OnDialogueOpen?.Invoke(false);
        //NEW
        //raceOneEnded = true;
    }
}
