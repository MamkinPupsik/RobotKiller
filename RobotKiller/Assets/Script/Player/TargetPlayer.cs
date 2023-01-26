using UnityEngine;

public class TargetPlayer : MonoBehaviour
{
    public float PlayerHealth = 1000f;

    public void PlayerDamage(float amount)
    {
        PlayerHealth -= amount;
        if (PlayerHealth < 0)
        {
            Die();
        }
    }

    void Die()
    {
        Destroy(this.gameObject);
    }
}
