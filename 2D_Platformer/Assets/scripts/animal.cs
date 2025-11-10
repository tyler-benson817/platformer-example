using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class animal : MonoBehaviour
{
    public List<questionsandanswers> QnA;
    public GameObject[] options;
    public int CurrentQuestion;

    public TextMeshProUGUI QuestionTxt;

    private void Start()
    {
        if (QnA.Count > 0)
            GenerateQuestion();
        else
            QuestionTxt.text = "No questions available.";
    }

    public void Correct()
    {
        QnA.RemoveAt(CurrentQuestion);
        if (QnA.Count > 0)
            GenerateQuestion();
        else
            QuestionTxt.text = "Quiz Complete!";
    }

    private void SetAnswers()
    {
        for (int i = 0; i < options.Length; i++)
        {
            var answerScript = options[i].GetComponent<AnswerScript>();
            answerScript.isCorrect = false;

            var answerText = options[i].transform.GetChild(0).GetComponent<TextMeshProUGUI>();
            answerText.text = QnA[CurrentQuestion].Answers[i];

            if (QnA[CurrentQuestion].CorrectAnswer == i)
            {
                answerScript.isCorrect = true;
            }
        }

    }

    private void GenerateQuestion()
    {
        CurrentQuestion = Random.Range(0, QnA.Count);
        QuestionTxt.text = QnA[CurrentQuestion].Question;
        SetAnswers();
    }
}
