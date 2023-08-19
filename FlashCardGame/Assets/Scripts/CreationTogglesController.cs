using System.Collections;
using System.Collections.Generic;
using UnityEngine;using UnityEngine.UI;

public class CreationTogglesController : MonoBehaviour
{
    
    /*TO DO---
    ADD REFERENCE FOR EITHER NEWCARDCREATOR OR FLASHCARDLISTMANAGER SO CREATION OF NEW CARDS WILL BE BASED
    ON TOGGLE CHANGES
    */
    
    public FlashcardListManager flashcardListManager;
    
    public Toggle isOpenAnswerToggle;
    public Toggle isMultipleChoiceToggle;
    public Toggle isCaseSensitiveToggle;
    
    // Start is called before the first frame update
    void Start()
    {
        isOpenAnswerToggle.isOn = true;
        isMultipleChoiceToggle.isOn = false;
        isCaseSensitiveToggle.isOn = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    //makes it so open answer and multiple choice toggle cannot both be true at the same time
    public void OpenAnswerToggleEvent()
    {
        //deactivate turn multiple choice toggle off when open answer is turned on
        //make case sensitive interactable when open answer turned on
        if (isOpenAnswerToggle.isOn)
        {
            isMultipleChoiceToggle.isOn = false;
            isCaseSensitiveToggle.interactable = true;
        }
        //make case sensitive not interactable and turn it off when open answer is turned off
        else if (!isOpenAnswerToggle.isOn)
        {
            isCaseSensitiveToggle.isOn = false;
            isCaseSensitiveToggle.interactable = false;
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
        }
        //make case sensitive interactable when multiple choice is turned off
        else if (!isMultipleChoiceToggle.isOn)
        {
            isCaseSensitiveToggle.interactable = true;
        }
    }
}
