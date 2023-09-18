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

    public List<Toggle> togglesList = new List<Toggle>();

    public Toggle caseSensitiveToggle;

    public TMP_InputField answerInput;

    public TextMeshPro questionText,
        answerText;

    private void Start()
    {
        flashcardListManager = GetComponent<FlashcardListManager>();
        errorDisplayController = GetComponent<ErrorDisplayController>();
    }

    public void OpenAnswerCardSetup()
    {
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
            //mark Attempt UI toggles
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
                
                //---show answer---
                errorDisplayController.DisplayErrorText("Incorrect. "+ attemptsRemaining + " attempts remaining");
            }
        }
    }
    

}
