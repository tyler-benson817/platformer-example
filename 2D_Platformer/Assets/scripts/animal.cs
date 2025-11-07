using System.Collections.Generic;
using TMPro;

//using TMPro;
//using Unity.Multiplayer.Center.Common;
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
        generateQuestion();
    }

    public void correct()
    {
        QnA.RemoveAt(CurrentQuestion);
        generateQuestion();
    }

    private void SetAnswers()
    {
        for (int i = 0; i < options.Length; i++)
        {
            options[i].GetComponent<AnswerScript>().isCorrect = false;
            options[i].transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = QnA[CurrentQuestion].Answers[i];
            options[i].transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = QnA[CurrentQuestion].Answers[i];

            if (QnA[CurrentQuestion].CorrectAnswer == i + 1)

            {
                options[i].transform.GetComponent<AnswerScript>().isCorrect = true;
            }
        }
    }
    private void generateQuestion()
    {
            CurrentQuestion = Random.Range(0, QnA.Count);

            QuestionTxt.text = QnA[CurrentQuestion].Question;

            SetAnswers();
    }
}