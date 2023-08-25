using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ErrorDisplayController : MonoBehaviour
{
    public TextMeshPro errorText;

    //update errorText with errorMessage and display the text for the user 
    public void DisplayErrorText(string errorMessage)
    {
        errorText.text = errorMessage;
    }
}
