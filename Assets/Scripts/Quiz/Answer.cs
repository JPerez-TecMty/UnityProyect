using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Answer : MonoBehaviour
{
    private bool isCorrect = false;
    public QuizManager quizManager;
    public void tryAnswer()
    {
        if (isCorrect)
        {
            Debug.Log("Correct Answer");
            quizManager.correct();
        }
        else
        {
            Debug.Log("Wrong Answer");
            quizManager.correct();
        }
    }

    public void ChangeToTrue()
    {
        isCorrect = true;
    }

    public void ChangeToFalse()
    {
        isCorrect = false;
    }
}
