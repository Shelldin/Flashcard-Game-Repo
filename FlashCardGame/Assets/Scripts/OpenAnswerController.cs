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

    public List<Toggle> togglesList = new List<Toggle>();

    public Toggle caseSensitiveToggle;

    public TMP_InputField answerInput;

    public TextMeshPro questionText,
        answerText;

    private void Start()
    {
        flashcardListManager = GetComponent<FlashcardListManager>();
    }

    public void OpenAnswerCardSetup()
    {
        for (int i = 0; i < togglesList.Count; i++)
        {
            togglesList[i].isOn = false;
        }
    }

    public void SubmitEvent()
    {
        if (answerInput.text == answerText.text)
        {
            //show answer
            //congratulation message
        }
        else if (answerInput.text != answerText.text)
        {
            bool allAttemptsUsed = true;
            for (int i = 0; i < togglesList.Count; i++)
            {
                if (togglesList[i].isOn = true)
                {
                    allAttemptsUsed = true;
                }
                else
                {
                    allAttemptsUsed = false;
                }
            }
        }
    }
    

}
