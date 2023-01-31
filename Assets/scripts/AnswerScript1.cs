using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnswerScript1 : MonoBehaviour
{
    public bool isCorrect = false;
    public QuizManager1 quizManager1;
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
            quizManager1.Correct();
           // question1.SetActive(false);
        }
        else
        {
            GetComponent<Image>().color = Color.red;
            Debug.Log("Wrong Answer");
            quizManager1.Wrong();
        }
    }

}
