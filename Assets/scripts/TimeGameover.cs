using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeGameover : MonoBehaviour
{
    int countDownStartvalue = 5;
    public Text timerUI;
    public GameObject QuestionMenu;
    // Start is called before the first frame update
    void Start()
    {
        countDownTimer();
    }
    void countDownTimer()
    {
     if (countDownStartvalue > 0)
        {
            timerUI.text = "Timer :" + countDownStartvalue;
            countDownStartvalue--;
            Invoke("countDownTimer", 1.0f);
        }
        else
        {
            QuestionMenu.gameObject.SetActive(false);


        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
