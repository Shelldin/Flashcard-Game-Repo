using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class NewCardCreator : MonoBehaviour
{
    public FlashcardListManager flashcardListManager;
    public CreationTogglesController creationTogglesController;
    
    public TMP_InputField questionInput;
    public TMP_InputField answerInput;

    public ErrorDisplayController errorDisplayController;

    //set the question text for a new card to equal the text in the input field
    public void QuestionInputEvent()
    {
        flashcardListManager.newQuestion = questionInput.text;
    }
    //set the answer text for a new card to equal the text in the input field
    public void AnswerInputEvent()
    {
        flashcardListManager.newAnswer = answerInput.text;
    }

    //create new card once toggles and input fields have been filled/selected
    public void CreateNewCardButtonEvent()
    {
        if (!string.IsNullOrEmpty(flashcardListManager.newQuestion) && 
            !string.IsNullOrEmpty(flashcardListManager.newAnswer))
        {
            flashcardListManager.AddNewFlashcard(); 
        }
        //give error message if an input field is empty
        else if (string.IsNullOrEmpty(flashcardListManager.newQuestion))
        {
            errorDisplayController.DisplayErrorText("Please enter a question");
            Debug.Log("please enter a question");
        }
        else if(string.IsNullOrEmpty(flashcardListManager.newAnswer))
        {
            errorDisplayController.DisplayErrorText("Please enter an answer");
            Debug.Log("Please enter an answer");
        }
        
    }
    
}
