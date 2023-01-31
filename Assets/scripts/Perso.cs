using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    Rigidbody2D r;
    public Animator anim;
    bool Saut = false;
    float speed = 8;
    // Use this for initialization
    void Start()
    {
        r = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }
    // Update is called once per frame
    void Update()
    {
        
                if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                transform.Translate(new Vector2(1f, 0));
                anim.SetInteger("Direction", 1);
            }
            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                transform.Translate(new Vector2(-1f, 0));
                anim.SetInteger("Direction", 2);

            }
            if (Input.GetKeyDown(KeyCode.Space) && Saut)
            {
                Sauter();
                anim.SetInteger("Direction", 3);

            }
        }
        void Sauter()
        {
            Vector2 SautPerso = new Vector2(0, speed);
            //r.AddForce (SautPerso);
            r.velocity = SautPerso;

        }

        void OnCollisionEnter2D(Collision2D autreobj)
    {
        if (autreobj.gameObject.tag == "Plateforme")
            Saut = true;
        if (autreobj.gameObject.tag == "Enemi")
            Destroy(autreobj.gameObject);
    }

    void OnCollisionExit2D(Collision2D autreobj)
    {
        if (autreobj.gameObject.tag == "Plateforme")
            Saut = false;
    }
}
