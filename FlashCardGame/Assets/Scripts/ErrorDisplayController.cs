using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ErrorDisplayController : MonoBehaviour
{
    public TextMeshPro errorText;

    public float errorCountdownTime = 5f;

    public Coroutine errorDisplayCountdownCo;
    

    private void Start()
    {
        //errorDisplayCountdownCo = StartCoroutine()
    }

    //update errorText with errorMessage and display the text for the user 
    public void DisplayErrorText(string errorMessage)
    {
        errorText.text = errorMessage;
    }

    //NOTE TO SELF: FINISH THE COROUTINE
    
    private IEnumerator ErrorDisplayCoroutine()
    {
        errorText.gameObject.SetActive(true);
        yield return new WaitForSeconds(errorCountdownTime);
    }
}
