using UnityEngine;

public class EnemyPatrol : MonoBehaviour
{
  

    public int damageOnCollision = 3;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.CompareTag("Player"))
        {
            PlayerHealth playerHealth = collision.transform.GetComponent<PlayerHealth>();
            playerHealth.TakeDamage(3);
         
        }
    }

    
}
