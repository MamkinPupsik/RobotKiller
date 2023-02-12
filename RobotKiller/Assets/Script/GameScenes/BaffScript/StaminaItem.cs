using UnityEngine;

public class StaminaItem : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Stamina stamina = GameObject.Find("Player").GetComponent<Stamina>();
        if (other.gameObject.tag == "Player")
        {
            stamina._currentStamina += 50f;
            Destroy(this.gameObject);
        }
    }
}
