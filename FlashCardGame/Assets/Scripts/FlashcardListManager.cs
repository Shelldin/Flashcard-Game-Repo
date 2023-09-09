using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class FlashcardListManager : MonoBehaviour
{
    [SerializeField]
    public List<Flashcard> flashcards = new List<Flashcard>();

    public Flashcard currentFlashcard;

    public string newQuestion;
    public string newAnswer;

    public bool isOpenAnswer;
    public bool isCaseSensitive;
    

    //add new flash card to list based on parameters set by user
    public void AddNewFlashcard()
    {
        flashcards.Add(new Flashcard(newQuestion, newAnswer, isOpenAnswer, isCaseSensitive));
    }

    public int SelectRandomFlashcard()
    {
        int randomFlashcardsIndex = Random.Range(0, flashcards.Count);
        return randomFlashcardsIndex;
    }
}
