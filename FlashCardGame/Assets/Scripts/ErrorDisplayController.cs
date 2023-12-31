using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;


public class ErrorDisplayController : MonoBehaviour
{
    public TMP_Text errorText;

    public float errorCountdownTime = 5f;

    private Coroutine errorDisplayCountdownCo;
    
    

    //update errorText with errorMessage and display the text for the user 
    public void DisplayErrorText(string errorMessage)
    {
        errorText.text = errorMessage;
        if (errorDisplayCountdownCo != null)
        {
            StopCoroutine(errorDisplayCountdownCo);
        }
        errorDisplayCountdownCo = StartCoroutine(ErrorDisplayCoroutine());
    }
    
    
    //activates error text game object for a few seconds and then deactivates it
    private IEnumerator ErrorDisplayCoroutine()
    {
        errorText.gameObject.SetActive(true);
        yield return new WaitForSeconds(errorCountdownTime);
        errorText.gameObject.SetActive(false);
    }
}
