using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Book : MonoBehaviour
{
    public GameObject book;
    public GameObject book1;
    public GameObject book2;
    public GameObject book3;
    public GameObject book4;

    void OnCollisionEnter2D(Collision2D obj)
    {
        if (obj.gameObject.tag == "book")
        {
            book.gameObject.SetActive(true);
           
        }

        if (obj.gameObject.tag == "book1")
        {
            book1.gameObject.SetActive(true);
           
        }

        if (obj.gameObject.tag == "book2")
        {
            book2.gameObject.SetActive(true);
            
        }

        if (obj.gameObject.tag == "book3")
        {
            book3.gameObject.SetActive(true);
          
        }

        if (obj.gameObject.tag == "book4")
        {
            book4.gameObject.SetActive(true);
           
        }

        if (obj.gameObject.tag == "quiz")
        {
            SceneManager.LoadScene("quiz");

        }
    }


   

}
