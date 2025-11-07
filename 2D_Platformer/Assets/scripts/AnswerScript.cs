using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnswerScript : MonoBehaviour
{
    public bool isCorrect = false;
    public animal animal;

  public void Answer()
    {
        if (isCorrect)
        {
            Debug.Log(" correct answer ");
            animal.correct();
        }
        else
        {
            Debug.Log(" wrong answer ");
            animal.correct(); 
        }
    }
}
