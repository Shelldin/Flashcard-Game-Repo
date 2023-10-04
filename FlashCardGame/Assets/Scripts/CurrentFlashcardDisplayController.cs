using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CurrentFlashcardDisplayController : MonoBehaviour
{
    
    public FlashcardListManager flashcardListManager;

    public OpenAnswerController openAnswerController;

    public ErrorDisplayController errorDisplayController;

    public GameObject openAnswerUIObject;
    public GameObject multipleChoiceUIObject;

    public Button viewYourAnswerButton,
        viewCorrectAnswerButton;

    private Flashcard currentFlashcard;
    

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
    private void SetFlashcardUI()
    {
        flashcardListManager.SelectRandomFlashcard();

         currentFlashcard = flashcardListManager.currentFlashcard;
        
        openAnswerController.answerInput.gameObject.SetActive(true);

        openAnswerController.questionText.text = currentFlashcard.question;
        openAnswerController.answerText.text = currentFlashcard.answer;
        openAnswerController.caseSensitiveToggle.isOn = currentFlashcard.caseSensitive;
        openAnswerController.attemptsTakenInt = 0;
        
        openAnswerController.ResetAttempts();
    }
    
    //activate answer text game object
    private void ActivateTextAnswerObj(Flashcard flashcard)
    {
        if (currentFlashcard.openAnswer)
        {
            openAnswerController.answerText.gameObject.SetActive(true);
        }
        else if(!currentFlashcard.openAnswer)
        {
            //MULTIPLE CHOICE ANSWER
        }
    }

    //swap between the user answer and the correct answer with a button
    public void SwapAnswerViewEvent()
    {
        if (viewYourAnswerButton.gameObject.activeSelf)
        {
            viewYourAnswerButton.gameObject.SetActive(false);
            viewCorrectAnswerButton.gameObject.SetActive(true);
            openAnswerController.answerText.gameObject.SetActive(false);
            openAnswerController.answerInput.gameObject.SetActive(true);
        }
        else if (viewCorrectAnswerButton.gameObject.activeSelf)
        {
            viewCorrectAnswerButton.gameObject.SetActive(false);
            viewYourAnswerButton.gameObject.SetActive(true);
            openAnswerController.answerInput.gameObject.SetActive(false);
            ActivateTextAnswerObj(currentFlashcard);
            //openAnswerController.answerText.gameObject.SetActive(true);
        }
    }
    
}
