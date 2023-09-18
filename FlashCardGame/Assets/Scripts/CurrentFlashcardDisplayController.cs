using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CurrentFlashcardDisplayController : MonoBehaviour
{
    
    public FlashcardListManager flashcardListManager;

    public OpenAnswerController openAnswerController;

    public ErrorDisplayController errorDisplayController;

    public GameObject openAnswerUIObject;
    public GameObject multipleChoiceUIObject;
    

    // Start is called before the first frame update
    private void Start()
    {
        flashcardListManager = GetComponent<FlashcardListManager>();
        openAnswerController = GetComponent<OpenAnswerController>();
        errorDisplayController = GetComponent<ErrorDisplayController>();
        
        //THIS IS IN THE START FUNCTION FOR TESTING/DEBUGGING:
        SetFlashcardUI();
    }
    
    //set the Flashcard UI based on a randomly selected flashcard
    public void SetFlashcardUI()
    {
        flashcardListManager.SelectRandomFlashcard();

        Flashcard currentFlashcard = flashcardListManager.currentFlashcard;

        openAnswerController.questionText.text = currentFlashcard.question;
        openAnswerController.answerText.text = currentFlashcard.answer;
        openAnswerController.caseSensitiveToggle.isOn = currentFlashcard.caseSensitive;
    }
    
}
