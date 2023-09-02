using System;
using System.Collections;
using System.Collections.Generic;
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

    public Input answerInput;

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
    

}
