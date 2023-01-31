using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class drapeau : MonoBehaviour
{
    public GameObject Nextlevel;

    void OnCollisionEnter2D(Collision2D obj)
    {
        if (obj.gameObject.tag == "drapeau")
        {
            Nextlevel.gameObject.SetActive(true); ;

        }
    }
}
