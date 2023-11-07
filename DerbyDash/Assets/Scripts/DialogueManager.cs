using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DialogueManager : MonoBehaviour
{
    public delegate void DialogueOpen(bool value);
    public delegate void DialogueText(string dialogueText);

    public static event DialogueText OnDialogueText;
    public static event DialogueText OnDialogueName;
    public static event DialogueOpen OnDialogueOpen;

    public Text nameText;
    public Text dialogueText;

    //NEW 10/02/2023
    //public bool raceOneEnded = false;

    //private DialogueTrigger _dialogueTrigger;

    public Queue<string> sentences;

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
        OnDialogueOpen?.Invoke(true);

        OnDialogueName?.Invoke(dialogue.name);

        sentences.Clear();

        foreach (string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);
        }

        DisplayNextSentence();
    }

    //NEW 10/03/2023
    //Sentence 2
    //public void StartDialogueTwo (Dialogue dialogueTwo)
    //{
    //    if (raceOneEnded == true)
    //    {
    //        OnDialogueOpen?.Invoke(true);

    //        OnDialogueName?.Invoke(dialogueTwo.name);

    //        sentences.Clear();

    //        foreach (string sentence in dialogueTwo.sentences)
    //        {
    //            sentences.Enqueue(sentence);
    //        }

    //        DisplayNextSentence();
    //    }
    //}

    public void DisplayNextSentence ()
    {
        if (SceneManager.GetActiveScene().name == "HomeSceneMain")
        {
            if (sentences.Count == 0)
            {
                EndDialogue();
                return;
            }
        }

        else
        {
            if (sentences.Count == 0)
            {
                EndDialogue();
                SceneManager.LoadScene("RaceScene");
                return;
            }
        }

        string sentence = sentences.Dequeue();
        StopAllCoroutines();
        StartCoroutine(TypeSentence(sentence));
    }

    IEnumerator TypeSentence (string sentence)
    {
        Debug.Log("Continue dialogue");
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

        //NEW 10/03/2023
        //raceOneEnded = true;
        //Debug.Log("Race one ended = true");
    }
}
