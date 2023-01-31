using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
    public GameObject PauseMenu;
    public GameObject book;
    public GameObject book1;
    public GameObject book2;
    public GameObject book3;
    public GameObject book4;
    public void playgame()
    {
        SceneManager.LoadScene("selectlevel");
    }
    public void optiongame()
    {
        SceneManager.LoadScene("options");
    }
    public void quitgame()
    {
        Application.Quit();
    }
    public void home()
    {
        SceneManager.LoadScene("interface d'acceuil");
    }
    public void replay()
    {
        SceneManager.LoadScene("SampleScene");
    }
    public void level1()
    {
        SceneManager.LoadScene("SampleScene");
    }
    public void RETOUR()
    {
        SceneManager.LoadScene("interface d'acceuil");
    }
    public void level2()
    {
        SceneManager.LoadScene("level22");
    }
    public void replayLose()
    {
        SceneManager.LoadScene("SampleScene");
    }
    public void replayLose3()
    {
        SceneManager.LoadScene("level22");
    }
    public void homeLose()
    {
        SceneManager.LoadScene("interface d'acceuil");
    }
    public void homeLose2()
    {
        SceneManager.LoadScene("interface d'acceuil");
    }
    public void Pause()
    {
        PauseMenu.gameObject.SetActive(true);
    }

    public void Next()
    {
        SceneManager.LoadScene("planets");
    }
    public void Next1()
    {
        SceneManager.LoadScene("planets2");
    }
    public void Next2()
    {
        SceneManager.LoadScene("planets3");

    }
    public void Next3()
    {
        SceneManager.LoadScene("planets4");
    }
    public void Next4()
    {
        SceneManager.LoadScene("planets5");
    }
    public void Next5()
    {
        SceneManager.LoadScene("interface d'acceuil");

    }
    public void back()
    {
        SceneManager.LoadScene("instruction");

    }
    public void back2()
    {
        SceneManager.LoadScene("planets");

    }
    public void back3()
    {
        SceneManager.LoadScene("planets2");

    }
    public void back4()
    {
        SceneManager.LoadScene("planets3");

    }
    public void back5()
    {
        SceneManager.LoadScene("planets4");

    }
    public void help()
    {
        SceneManager.LoadScene("instruction");

    }
    public void backoption()
    {
        SceneManager.LoadScene("interface d'acceuil");

    }

    public void Next10()
    {
        SceneManager.LoadScene("level22");
    }

    public void OK()
    {
            book.gameObject.SetActive(false);
        
    }
    public void OK1()
    {
        book1.gameObject.SetActive(false);

    }
    public void OK2()
    {
        book2.gameObject.SetActive(false);

    }
    public void OK3()
    {
        book3.gameObject.SetActive(false);

    }
    public void OK4()
    {
        book4.gameObject.SetActive(false);

    }
   

}

