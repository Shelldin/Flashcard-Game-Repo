using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class NewCardCreator : MonoBehaviour
{
    public FlashcardListManager flashcardListManager;

    //empty game object that contains all the card creation UI elements
    public GameObject creatorUIGameObject;

    public TextMeshPro questionText;
    public TextMeshPro answerText;

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
}
