using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class OpenAnswerController : MonoBehaviour
{
    
    /*
     * -CHECK ANSWER
     * - TOGGLES FOR ATTEMPTS
     * - CASE SENSITIVE CHECK
     */
    public FlashcardListManager flashcardListManager;

    public ErrorDisplayController errorDisplayController;

    public CurrentFlashcardDisplayController currentFlashcardDisplayController;

    public List<Toggle> togglesList = new List<Toggle>();

    public Toggle caseSensitiveToggle;

    public TMP_InputField answerInput;

    public TMP_Text questionText,
        answerText;

    public int attemptsTakenInt;

    private void Start()
    {
        flashcardListManager = GetComponent<FlashcardListManager>();
        errorDisplayController = GetComponent<ErrorDisplayController>();
    }

    public void ResetAttempts()
    {
        attemptsTakenInt = 0;
        
        for (int i = 0; i < togglesList.Count; i++)
        {
            togglesList[i].isOn = false;
        }
    }

    // check to see if user's answer matches the correct answer
    // if correct give success message and move to next card
    // if incorrect give error message and mark the attempt (move to next card if out of attempts)
    public void SubmitEvent()
    {
        //if correct answer is given
        if (answerInput.text == answerText.text)
        {
            //--show answer--
            errorDisplayController.DisplayErrorText("Correct!!!");
        }
        //if incorrect
        else if (answerInput.text != answerText.text)
        {
            //mark attempt toggle
            if (attemptsTakenInt < togglesList.Count)
            {
                togglesList[attemptsTakenInt].isOn = true;
                attemptsTakenInt++;
            }
            
            //check if there are any remaining attempts
            bool allAttemptsUsed = true;
            for (int i = 0; i < togglesList.Count; i++)
            {
                if (togglesList[i].isOn)
                {
                    allAttemptsUsed = true;
                }
                else
                {
                    allAttemptsUsed = false;
                }
            }

            //track attempts
            if (!allAttemptsUsed)
            {
                int attemptsRemaining = 3;

                for (int i = 0; i < togglesList.Count; i++)
                {
                    if (togglesList[i].isOn)
                    {
                        attemptsRemaining--;
                        if (attemptsRemaining < 0)
                        {
                            attemptsRemaining = 0;
                        }
                    }
                }
                errorDisplayController.DisplayErrorText("Incorrect. "+ attemptsRemaining + " attempts remaining");
            }
            else
            {
                errorDisplayController.DisplayErrorText("Incorrect. No attempts remaining");
                currentFlashcardDisplayController.viewYourAnswerButton.gameObject.SetActive(true);
                currentFlashcardDisplayController.viewYourAnswerButton.interactable = true;
            }
        }
    }
    

}
