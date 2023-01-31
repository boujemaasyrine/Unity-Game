using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class QuizManager1 : MonoBehaviour
{

    public List<QuestionAndAnswers> QnA;
    public int currentHealth;
    public GameObject[] options;
    //  public HealthBar healthBar;
    //int damage = 20;  
    public int currentQuestion;
    public GameObject QuestionMenu1;

    public static PlayerHealth instance;

    public Text QuestionTxt;


    int totalQuestions = 1;


    private void Start()
    {
        totalQuestions = QnA.Count;

        generateQuestion();
    }




    public void Correct()
    {

        QnA.RemoveAt(currentQuestion);
        StartCoroutine(waitForNext());
        Inventory.instance.AddCoins(5);
    }

    public void Wrong()
    {

        QnA.RemoveAt(currentQuestion);
        StartCoroutine(waitForNext());
        PlayerHealth.instance.TakeDamage(20);
    }

    IEnumerator waitForNext()
    {
        yield return new WaitForSeconds(1);
        //QuestionMenu.gameObject.SetActive(true);
        generateQuestion();
    }

    void SetAnswers1()
    {
        for (int i = 0; i < options.Length; i++)
        {
            options[i].GetComponent<Image>().color = options[i].GetComponent<AnswerScript1>().startColor;
            options[i].GetComponent<AnswerScript1>().isCorrect = false;
            options[i].transform.GetChild(0).GetComponent<Text>().text = QnA[currentQuestion].Answers[i];

            if (QnA[currentQuestion].CorrectAnswer == i + 1)
            {
                options[i].GetComponent<AnswerScript1>().isCorrect = true;
            }
        }
    }

    void generateQuestion()
    {
        if (QnA.Count > 0)
        {
            currentQuestion = Random.Range(0, QnA.Count);

            QuestionTxt.text = QnA[currentQuestion].Question;
            SetAnswers1();
        }
        else
        {
            QuestionMenu1.gameObject.SetActive(false);
            // QuestionMenu1.gameObject.SetActive(false);
        } }


    }


