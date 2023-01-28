using UnityEngine;

public class HealthItem : MonoBehaviour
{
    public float health_item;


    public void OnTriggerEnter(Collider other)
    {
        TargetPlayer targetplayer = GameObject.Find("Player").GetComponent<TargetPlayer>();
        if (other.gameObject.tag == "Player") {
            health_item = targetplayer.PlayerHealth += 100f;
            Destroy(this.gameObject);
        }
    }
}
