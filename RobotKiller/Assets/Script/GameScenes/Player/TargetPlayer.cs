using UnityEngine;
using UnityEngine.SceneManagement;

public class TargetPlayer : MonoBehaviour
{
    public GameObject _crosshair;
    public float PlayerHealth = 100f;
    public bool HealthLoose = false;

    private void Update()
    {
        if (PlayerHealth <= 0)
        {
            _crosshair.SetActive(false);
            SceneManager.LoadScene("DeathScene");
        }
    }
}
