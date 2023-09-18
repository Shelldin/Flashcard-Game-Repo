using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CurrentFlashcardDisplayController : MonoBehaviour
{
    
    public FlashcardListManager flashcardListManager;

    public OpenAnswerController openAnswerController;

    public ErrorDisplayController errorDisplayController;
    

    // Start is called before the first frame update
    private void Start()
    {
        flashcardListManager = GetComponent<FlashcardListManager>();
        openAnswerController = GetComponent<OpenAnswerController>();
        errorDisplayController = GetComponent<ErrorDisplayController>();
    }
    
    
}
