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
}
