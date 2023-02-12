using UnityEngine;

public class TargetPlayer : MonoBehaviour
{
    public float PlayerHealth = 100f;
    public bool HealthLoose = false;

    private void Update()
    {
        if (PlayerHealth <= 0)
        {
            WindowLoose();
        }
    }

    void WindowLoose()
    {
        HealthLoose = true;
        Time.timeScale = 0f;
    }

    private void OnGUI()
    {
        if (HealthLoose == true)
        {
            GUI.Box(new Rect(Screen.width / 2 - 100, Screen.height / 2 - 50, 200, 100), "DIE!");
        }
        
    }


}
