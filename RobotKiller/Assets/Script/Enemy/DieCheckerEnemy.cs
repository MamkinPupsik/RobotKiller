using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DieCheckerEnemy : MonoBehaviour
{
    public TargetEnemy targetenemy;
    public int EnemyKilledChecker = 0;
    private bool WinWidows = false;

    private void Update()
    {
        if (EnemyKilledChecker >= 1)
        {
            WinWindow();
        }
    }

    void OnGUI()
    {
        GUI.Box(new Rect(20, 50, 150, 25), "Enemy killed: " + EnemyKilledChecker);
        if (WinWidows == true)
        {
            GUI.Box(new Rect(Screen.width / 2 - 100, Screen.height / 2 - 50, 200, 100), "YOU WON!");
        }
        

        
    }

    void WinWindow()
    {
        Time.timeScale = 0f;
        WinWidows = true;
    }
}
