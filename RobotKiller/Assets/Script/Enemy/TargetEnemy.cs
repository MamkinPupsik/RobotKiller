using UnityEngine;
using UnityEngine.UI;

public class TargetEnemy : MonoBehaviour
{
    public float health = 100f;
    public int EnemyDieChecked = 0;
    public GameObject health_item;
    private Slider hpstat;
    public DieCheckerEnemy dieCheckerEnemy;

    public void TakeDamage(float amount)
    {
        hpstat = transform.Find("Canvas/Panel/Slider").gameObject.GetComponent<Slider>();
        hpstat.value = health;
        health -= amount;
        if(health < 0)
        {
            dieCheckerEnemy.EnemyKilledChecker =  EnemyDieChecked += 1;
            Die();
        }
    }

    void Die()
    {      
        Destroy(this.gameObject);
        Instantiate(health_item, this.transform.position, Quaternion.identity);
    }
}

