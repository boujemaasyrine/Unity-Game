using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnswerScript3 : MonoBehaviour
{
    public bool isCorrect = false;
    public QuizManager3 quizManager3;
    public GameObject question1;
    public Color startColor;

    private void Start()
    {
        startColor = GetComponent<Image>().color;
    }

    public void Answer()
    {
        if (isCorrect)
        {
            GetComponent<Image>().color = Color.green;
            Debug.Log("Correct Answer1");
            quizManager3.Correct();
            // question1.SetActive(false);
        }
        else
        {
            GetComponent<Image>().color = Color.red;
            Debug.Log("Wrong Answer");
            quizManager3.Wrong();
        }
    }

}