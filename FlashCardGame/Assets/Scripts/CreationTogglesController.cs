using System.Collections;
using System.Collections.Generic;
using UnityEngine;using UnityEngine.UI;

public class CreationTogglesController : MonoBehaviour
{
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
        if (isOpenAnswerToggle.isOn)
        {
            isMultipleChoiceToggle.isOn = false;
            isCaseSensitiveToggle.interactable = true;
        }
        else if (!isOpenAnswerToggle.isOn)
        {
            isCaseSensitiveToggle.interactable = false;
        }
    }
    
    //makes it so open answer and multiple choice toggle cannot both be true at the same time
    public void MultipleChoiceToggleEvent()
    {
        if (isMultipleChoiceToggle.isOn)
        {
            isOpenAnswerToggle.isOn = false;
            isCaseSensitiveToggle.interactable = false;
        }
        else if (!isMultipleChoiceToggle.isOn)
        {
            isCaseSensitiveToggle.interactable = true;
        }
    }
}
