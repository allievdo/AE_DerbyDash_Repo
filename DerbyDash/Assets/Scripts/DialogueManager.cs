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

    public int textCount;

    public GameObject amandaSprite;
    public Image image;

    public Sprite AddImageNormal()
    {
        return Resources.Load<Sprite>("Amanda_Normal");
    }
    public Sprite AddImageReallyHappy()
    {
        return Resources.Load<Sprite>("Amanda_BigSmile");
    }

    public Sprite AddImageFrown()
    {
        return Resources.Load<Sprite>("Amanda_Frowning");
    }

    public Sprite AddImageSilly()
    {
        return Resources.Load<Sprite>("Amanda_Silly");
    }
    //NEW 10/02/2023
    //public bool raceOneEnded = false;

    //private DialogueTrigger _dialogueTrigger;

    public Queue<string> sentences;

    void Start()
    {
        amandaSprite.SetActive(false);
        sentences = new Queue<string>();
        textCount = 0;
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

    public void DisplayNextSentence ()
    {
        if (SceneManager.GetActiveScene().name == "HomeSceneMain")
        {
            textCount++;
            if(textCount == 1)
            {
                amandaSprite.SetActive(true);
                AddImageReallyHappy();
                image.sprite = AddImageReallyHappy();
            }

            if(textCount == 2)
            {
                AddImageNormal();
                image.sprite = AddImageNormal();
            }

            if(textCount == 4)
            {
                AddImageSilly();
                image.sprite = AddImageSilly();
            }

            if (sentences.Count == 0)
            {
                textCount = 0;
                amandaSprite.SetActive(false);
                EndDialogue();
                return;
            }
        }

        if(SceneManager.GetActiveScene().name == "HomeSceneCompleteHard")
        {
            textCount++;
            if (textCount == 1)
            {
                amandaSprite.SetActive(true);
                AddImageReallyHappy();
                image.sprite= AddImageReallyHappy();
            }

            if(textCount == 2)
            {
                AddImageSilly();
                image.sprite= AddImageSilly();
            }

            if(textCount == 3)
            {
                AddImageNormal();
                image.sprite = AddImageNormal();
            }
            

            if(textCount == 5)
            {
                AddImageReallyHappy();
                image.sprite= AddImageSilly();
            }

            if (sentences.Count == 0)
            {
                textCount = 0;
                amandaSprite.SetActive(false);
                EndDialogue();
                return;
            }
        }

        if(SceneManager.GetActiveScene().name == "HomeScene")
        {
            textCount++;
            if (textCount == 1)
            {
                amandaSprite.SetActive(true);
                AddImageReallyHappy();
                image.sprite = AddImageReallyHappy();
            }

            if(textCount == 2)
            {
                AddImageFrown();
                image.sprite = AddImageFrown();
            }

            if (textCount == 3)
            {
                AddImageNormal();
                image.sprite = AddImageNormal();
            }

            if( textCount == 6)
            {
                AddImageSilly();
                image.sprite = AddImageSilly();
            }

            if (sentences.Count == 0)
            {
                textCount = 0;
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
        //Debug.Log("Continue dialogue");
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
    }
}
