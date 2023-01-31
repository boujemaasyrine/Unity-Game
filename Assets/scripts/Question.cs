using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Question : MonoBehaviour
{
    public GameObject QuestionMenu;
    public GameObject QuestionMenu1;
    public GameObject QuestionMenu2;
    public GameObject QuestionMenu3;
    public GameObject QuestionMenu5;
    public GameObject QuestionMenu9;
    public GameObject UITimer;
    void OnCollisionEnter2D(Collision2D obj)
    {
        if (obj.gameObject.tag == "question")
        {
            QuestionMenu.gameObject.SetActive(true);
            Destroy(obj.gameObject);
        }    
         

         if (obj.gameObject.tag == "question1")
        {

            QuestionMenu1.gameObject.SetActive(true);
            UITimer.gameObject.SetActive(true);
            Debug.Log("OnCollisionEnter2D");
            Destroy(obj.gameObject);

        }
        if (obj.gameObject.tag == "question2")
        {

            QuestionMenu2.gameObject.SetActive(true);
            UITimer.gameObject.SetActive(true);
            Debug.Log("OnCollisionEnter2D");
            //Destroy(obj.gameObject);

        }
        if (obj.gameObject.tag == "question3")
        {

            QuestionMenu3.gameObject.SetActive(true);
            UITimer.gameObject.SetActive(true);
            Debug.Log("OnCollisionEnter2D");
            //Destroy(obj.gameObject);

        }
        
        if (obj.gameObject.tag == "question6")
        {
            QuestionMenu9.gameObject.SetActive(true);
            // Destroy(obj.gameObject);
        }




    }

}

