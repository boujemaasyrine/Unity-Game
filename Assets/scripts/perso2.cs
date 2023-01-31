using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class perso2 : MonoBehaviour
{
    public float moveSpeed;
    public float Jumpforce;
    float dirX;
    Animator anim;
    private Rigidbody2D r;
    bool facingRight = true;
    Vector3 localScale;
    public int currentHealth;
    bool isHurting;
    private bool stop; 

    void Start()
    {
        r = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        localScale = transform.localScale;
    }

    // Update is called once per frame


    void Update()
    {
        dirX = Input.GetAxisRaw("Horizontal") * moveSpeed;
        if (!!Input.anyKey)
            anim.SetInteger("Direction", 2);
        if (Input.GetKey(KeyCode.LeftArrow))
        {

            transform.position = new Vector3(transform.position.x - moveSpeed, transform.position.y, transform.position.z);
            anim.SetInteger("Direction", 1);

        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position = new Vector3(transform.position.x + moveSpeed, transform.position.y, transform.position.z);
            anim.SetInteger("Direction", 1);
        }

       

        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position = new Vector3(transform.position.x, transform.position.y + moveSpeed, transform.position.z);
            anim.SetInteger("Direction", 3);
            anim.SetBool("isFlying", true);

        }



        if (!stop)
        {
            if (Input.GetKey(KeyCode.DownArrow))
            {
                transform.position = new Vector3(transform.position.x, transform.position.y - moveSpeed, transform.position.z);
                anim.SetBool("isFlying", true);
                anim.SetInteger("Direction", 3);
            }


        }

        if (Mathf.Abs(dirX) > 0 && r.velocity.y == 0)
            anim.SetBool("isRunning", true);
        else
        {
            anim.SetBool("isRunning", false);

        }

        if (r.velocity.y == 0)
        {
            anim.SetBool("isFlying", false);
           
        }
        if (r.velocity.y > 0)
        {
            anim.SetBool("isFlying", true);
        }


    }
    private void FixedUpdate()
    {
        if (!isHurting)
            r.velocity = new Vector2(dirX, r.velocity.y);
    }
    private void LateUpdate()
    {
        if (dirX > 0)
            facingRight = true;
        else
            facingRight = false;
        if (((facingRight) && (localScale.x < 0)) || ((!facingRight) && (localScale.x > 0)))
            localScale.x *= -1;
        transform.localScale = localScale;
    }

    private void OnCollisionEnter2D (Collision2D obj)
    {
       

        if (obj.gameObject.tag == "PlateForme")
        {
            stop = true;
        }
    }

    private void OnCollisionExit2D(Collision2D obj)
    {


        if (obj.gameObject.tag == "PlateForme")
        {
            stop = false;
        }
    }
}





