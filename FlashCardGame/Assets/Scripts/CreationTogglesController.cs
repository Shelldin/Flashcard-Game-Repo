using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;using UnityEngine.UI;

public class CreationTogglesController : MonoBehaviour
{
    
    
    public FlashcardListManager flashcardListManager;
    
    public Toggle isOpenAnswerToggle;
    public Toggle isMultipleChoiceToggle;
    public Toggle isCaseSensitiveToggle;

    private void Awake()
    {
        flashcardListManager = GetComponent<FlashcardListManager>();
    }

    // Start is called before the first frame update
    void Start()
    {
        isOpenAnswerToggle.isOn = true;
        isMultipleChoiceToggle.isOn = false;
        isCaseSensitiveToggle.isOn = false;
        //make sure the flash card manager booleans from the start
        SetFlashcardManagerBools();
    }
    

    // makes it so open answer and multiple choice toggle cannot both be true at the same time
   
    public void OpenAnswerToggleEvent()
    {
        /*deactivate turn multiple choice toggle off when open answer is turned on.
        make case sensitive interactable when open answer turned on.*/
        if (isOpenAnswerToggle.isOn)
        {
            isMultipleChoiceToggle.isOn = false;
            isCaseSensitiveToggle.interactable = true;
            SetFlashcardManagerBools();
        }
        //make case sensitive not interactable and turn it off when open answer is turned off
        else if (!isOpenAnswerToggle.isOn)
        {
            isCaseSensitiveToggle.isOn = false;
            isCaseSensitiveToggle.interactable = false;
           SetFlashcardManagerBools();
        }
    }
    
    //makes it so open answer and multiple choice toggle cannot both be true at the same time
    public void MultipleChoiceToggleEvent()
    {
        //turn case sensitive off and non interactable and open answer off when multiple choice turned on
        if (isMultipleChoiceToggle.isOn)
        {
            isOpenAnswerToggle.isOn = false;
            isCaseSensitiveToggle.isOn = false;
            isCaseSensitiveToggle.interactable = false;
            SetFlashcardManagerBools();
        }
        //make case sensitive interactable when multiple choice is turned off
        else if (!isMultipleChoiceToggle.isOn)
        {
            isCaseSensitiveToggle.interactable = true;
            SetFlashcardManagerBools();
        }
    }
    
    //what happens the CaseSensitive toggle is turned on or off
    public void CaseSensitiveToggleEvent()
    {
        SetFlashcardManagerBools();
    }
    
    //set the bools in FlashCardManager to equal the toggle isOn bools
    private void SetFlashcardManagerBools()
    {
        flashcardListManager.isOpenAnswer = isOpenAnswerToggle.isOn;
        flashcardListManager.isCaseSensitive = isCaseSensitiveToggle.isOn;
    }
}
