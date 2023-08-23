using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashcardListManager : MonoBehaviour
{
    [SerializeField]
    public List<Flashcard> flashcards = new List<Flashcard>();

    public string newQuestion;
    public string newAnswer;

    public bool isOpenAnswer;
    public bool isCaseSensitive;

    public void Start()
    {
        
    }

    public void AddNewFlashcard()
    {
        flashcards.Add(new Flashcard(newQuestion, newAnswer, isOpenAnswer, isCaseSensitive));
    }
}
