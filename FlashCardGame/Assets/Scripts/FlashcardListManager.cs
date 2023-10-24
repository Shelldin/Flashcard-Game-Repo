using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class FlashcardListManager : MonoBehaviour
{
    [SerializeField]
    public List<Flashcard> flashcards = new List<Flashcard>();

    public List<Flashcard> currentFlashcards = new List<Flashcard>();

    public List<Flashcard> usedFlashcards = new List<Flashcard>();

    public Flashcard currentFlashcard;

    public string newQuestion;
    public string newAnswer;

    public bool isOpenAnswer;
    public bool isCaseSensitive;

    private void Start()
    {
        //POPULATE CURRENT FLASHCARD FUNCTION
    }

    //add new flash card to list based on parameters set by user
    public void AddNewFlashcard()
    {
        flashcards.Add(new Flashcard(newQuestion, newAnswer, isOpenAnswer, isCaseSensitive));
    }

    //set a random int
    private int RandomFlashcardInt()
    {
        int randomFlashcardsIndex = Random.Range(0, flashcards.Count-1);
        return randomFlashcardsIndex;
    }

    // select a random flashcard from the list based on the random index selected
    public void SelectRandomFlashcard()
    {
        int randomIndex = RandomFlashcardInt();
        currentFlashcard = flashcards[randomIndex];
    }

    //remove flashcard from a list
    private void RemoveFlashcardFromList(List<Flashcard> listOfFlashcards, Flashcard flashcardToRemove)
    {
        listOfFlashcards.Remove(flashcardToRemove);
    }

    //move flashcards in one list to another list
    private void MoveFlashcards
        (Flashcard flashcardToMove, List<Flashcard> originalFlashcardList, List<Flashcard> newFlashcardList)
    {
        newFlashcardList.Add(flashcardToMove);
        RemoveFlashcardFromList(originalFlashcardList, flashcardToMove);
    }
}
