using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class QuizManager5 : MonoBehaviour
{
    public List<QuestionAndAnswers> QnA;
    public int currentHealth;
    public GameObject[] options;
    //  public HealthBar healthBar;
    //int damage = 20;  
    public int currentQuestion;
    public GameObject QuestionMenu5;

    public static PlayerHealth instance;

    public Text QuestionTxt1;


    int totalQuestions = 0;


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

    void SetAnswers()
    {
        for (int i = 0; i < options.Length; i++)
        {
            options[i].GetComponent<Image>().color = options[i].GetComponent<AnswerScript5>().startColor;
            options[i].GetComponent<AnswerScript5>().isCorrect = false;
            options[i].transform.GetChild(0).GetComponent<Text>().text = QnA[currentQuestion].Answers[i];

            if (QnA[currentQuestion].CorrectAnswer == i + 1)
            {
                options[i].GetComponent<AnswerScript5>().isCorrect = true;
            }
        }
    }

    void generateQuestion()
    {
        if (QnA.Count > 0)
        {
            currentQuestion = Random.Range(0, QnA.Count);

            QuestionTxt1.text = QnA[currentQuestion].Question;
            SetAnswers();

        }
        else
        {
            QuestionMenu5.gameObject.SetActive(false);


        }


    }
}
