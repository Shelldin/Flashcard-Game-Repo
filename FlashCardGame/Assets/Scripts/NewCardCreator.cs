using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class NewCardCreator : MonoBehaviour
{
    public FlashcardListManager flashcardListManager;
    public CreationTogglesController creationTogglesController;
    public ErrorDisplayController errorDisplayController;
    
    public TMP_InputField questionInput;
    public TMP_InputField answerInput;

    public Button finishButton;

    private int minimumListSize;

    private void Awake()
    {
        flashcardListManager = GetComponent<FlashcardListManager>();
        creationTogglesController = GetComponent<CreationTogglesController>();
        errorDisplayController = GetComponent<ErrorDisplayController>();

    }

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

        //check if list meets the minimum size each time a card is created
        MinimumCardListSizeCheck();
    }

    //check if the cardlist is at least the minimum size before letting the user finish creating cards
    public void MinimumCardListSizeCheck()
    {
        int flashcardListSize = flashcardListManager.flashcards.Count;
        
        if (flashcardListSize < minimumListSize)
        {
            finishButton.interactable = false;
        }
        else if (flashcardListSize >= minimumListSize)
        {
            finishButton.interactable = true;
        }
    }
}
