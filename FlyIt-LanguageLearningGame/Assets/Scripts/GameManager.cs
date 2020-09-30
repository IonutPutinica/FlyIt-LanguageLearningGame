using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class GameManager : MonoBehaviour
{
    public Question[] questions;
    //variable that will be used to remove already used questions from the queue
    private static List<Question> unansweredQuestions;

    //the question that the user can currently answer

    private Question currentQuestion;

    void Start()
    {
        if (unansweredQuestions == null || unansweredQuestions.Count==0)
        {
            unansweredQuestions = questions.ToList<Question>();
        }

        GetRandomQuestion();
        Debug.Log(currentQuestion.fact + " is " + currentQuestion.isTrue);

    }

    void GetRandomQuestion()
    {
        int randomQuestionIndex = Random.Range(0, unansweredQuestions.Count);
        currentQuestion = unansweredQuestions[randomQuestionIndex];

        //removing the already answered question from the queue

        unansweredQuestions.RemoveAt(randomQuestionIndex);
    }


}
