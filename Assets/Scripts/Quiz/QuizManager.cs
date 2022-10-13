using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class QuizManager : MonoBehaviour
{
    
    public List<QuestionsAndAnswers> qna;
    public GameObject[] options;
    private int questionIndex;

    public TextMeshProUGUI questiontxt;

    private void Start()
    {
        generateQuestion();
    }

    public void correct()
    {
        qna.RemoveAt(questionIndex); 
        generateQuestion();
    }
    void SetAnswers()
    {
        for(int i = 0; i < options.Length; i++)
        {
            options[i].GetComponent<Answer>().ChangeToFalse();

            options[i].transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = qna[questionIndex].answers[i];

            if (qna[questionIndex].correctAnswer == (i + 1))
            {
                options[i].GetComponent<Answer>().ChangeToTrue();
            }
        }
    }

    void generateQuestion()
    {
        questionIndex = Random.Range(0, qna.Count);
        questiontxt.text = qna[questionIndex].question;

        SetAnswers();
    }
}
