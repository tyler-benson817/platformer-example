
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnswerScript : MonoBehaviour
{
    public bool isCorrect = false;
    public animal animal; 

    public void Answer()
    {
        if (animal == null)
        {
            Debug.LogWarning("AnimalQuiz reference is missing.");
            return;
        }

        if (isCorrect)
        {
            Debug.Log("Correct answer");
            animal.Correct();
        }
        else
        {
            Debug.Log("Wrong answer");
            animal.Correct(); 
        }
    }
}
