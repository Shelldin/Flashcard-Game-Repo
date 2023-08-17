using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashcardListManager : MonoBehaviour
{
    public List<Flashcard> flashcards;

    public string newQuestion;
    public string newAnswer;

    public bool isOpenAnswer;
    public bool isCaseSensitive;

    public void Start()
    {
        flashcards = new List<Flashcard>();
    }

    public void CreateNewFlashcard()
    {
        flashcards.Add(new Flashcard(newQuestion, newAnswer, isOpenAnswer, isCaseSensitive));
    }
}
