using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnswerScript : MonoBehaviour
{
    public bool isCorrect = false;
    public QuizManager quizManager;

    public Color startColor;
    public GameObject question1;


    private void Start()
    {
        startColor = GetComponent<Image>().color;
    }

    public void Answer()
    {
        if(isCorrect)
        {
            GetComponent<Image>().color = Color.green;
            Debug.Log("Correct Answer");
            quizManager.correct();
            StartCoroutine(Wait());         
            
         
        }
        else
        {
            GetComponent<Image>().color = Color.red;
            Debug.Log("Wrong Answer");
            quizManager.wrong();
            StartCoroutine(Wait());
        }
    }

     
    IEnumerator Wait()
    {
        yield return new WaitForSecondsRealtime(1);

        question1.SetActive(false);
      
    }
}
