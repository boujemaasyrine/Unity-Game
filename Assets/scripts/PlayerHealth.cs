using System.Collections;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;
    public static PlayerHealth instance;
    public HealthBar healthBar;
    public GameObject youlose;
    public Animator animator;

    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }
    private void Awake()
    {
        if (instance != null)
        {
            Debug.LogWarning("Il y a plus d'une instance de PlayerHealth dans la scène");
            return;
        }

        instance = this;
    }





    public void HealPlayer(int amount)
    {
        if ((currentHealth + amount) > maxHealth)
        {
            currentHealth = maxHealth;
        }
        else
        {
            currentHealth += amount;
        }

        healthBar.SetHealth(currentHealth);
    }




    public void TakeDamage(int damage)
    {


        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);

        if (currentHealth <= 0)
        {
            Dead();
            StartCoroutine(Wait1());
            youlose.gameObject.SetActive(true);
        }

        IEnumerator Wait1()
        {
            yield return new WaitForSecondsRealtime(2);
        }
    }


    public void Dead()
    {
        Debug.Log("elemine");
        //perso.instance.enabled = false;

        animator.SetTrigger("Dead");
        // perso.instance.rb.bodyType = RigidbodyType2D.Kinematic;
        /// perso.instance.rb.velocity = Vector3.zero;
        // perso.instance.playerCollider.enabled = false;
        // GameOverManager.instance.OnPlayerDeath();
    }
    
}



