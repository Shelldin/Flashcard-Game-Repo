using System.Collections;
using System.Collections.Generic;

[System.Serializable]
public class Flashcard
{
    public string question;
    public string answer;
    
    public bool openAnswer;
    public bool caseSensitive;

    public Flashcard(string newQuestion, string newAnswer, bool isOpenAnswer, bool isCaseSensitive)
    {
        question = newQuestion;
        answer = newAnswer;

        openAnswer = isOpenAnswer;
        caseSensitive = isCaseSensitive;
    }
}
