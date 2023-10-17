//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using UnityEngine.UI;
//using UnityEngine.SceneManagement;

//public class DialogueContinue : MonoBehaviour
//{
//    public delegate void DialogueOpen(bool value);
//    public delegate void DialogueText(string dialogueText);

//    public static event DialogueText OnDialogueText;
//    public static event DialogueText OnDialogueName;
//    public static event DialogueOpen OnDialogueOpen;

//    DialogueManager _dialogueManager;

//    public Text nameText;
//    public Text dialogueText;

//    //NEW 10/10/2023
//    public void StartDialogueTwo(Dialogue dialogueTwo)
//    {
//        if (_dialogueManager.raceOneEnded == true)
//        {
//            OnDialogueOpen?.Invoke(true);

//            OnDialogueName?.Invoke(dialogueTwo.name);

//            _dialogueManager.sentences.Clear();

//            foreach (string sentence in dialogueTwo.sentences)
//            {
//                _dialogueManager.sentences.Enqueue(sentence);
//            }

//            _dialogueManager.DisplayNextSentence();
//        }
//    }
//}
