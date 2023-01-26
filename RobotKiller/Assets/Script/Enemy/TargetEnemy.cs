using UnityEngine;

public class TargetEnemy : MonoBehaviour
{
    public float health = 50f;
    public int EnemyDieChecked = 0;

    public void TakeDamage(float amount)
    {
        health -= amount;
        if(health < 0)
        {
            EnemyDieChecked += 1;
            Die();
        }
    }

    void Die()
    {      
        Destroy(gameObject);
    }
}

