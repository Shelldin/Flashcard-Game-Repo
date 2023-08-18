using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuController : MonoBehaviour
{
    public Button studyCardsButton;
    public Button newFlashcardButton;
    public Button editCardListButton;
    
    //empty game object containing Main Menu UI Elements
    public GameObject mainMenuUIGameObject;
    
    //empty game object that contains all the card creation UI elements
    public GameObject creatorUIGameObject;
    
    //game object containing basic Flashcard UI elements;
    public GameObject currentFlashcardUIGameObject;


    //activates the main menu
    public void ActivateMainMenu()
    {
        mainMenuUIGameObject.SetActive(true);
    }
    
    //deactivates the main menu
    public void DeactivateMainMenu()
    {
        mainMenuUIGameObject.SetActive(false);
    }
    
    //activate card creation UI
    public void ActivateNewCardCreation()
    {
        creatorUIGameObject.SetActive(true);
    }
    
    //deactivate the card creation UI
    public void DeactivateNewCardCreation()
    {
        creatorUIGameObject.SetActive(false);
    }
}
