using UnityEngine;

public class WindowWinLoose : MonoBehaviour
{
    //public DieCheckerEnemy dieCheckedEnemy;
    public int CheckerKilledEnemy; 

    void Update()
    {

       // dieCheckedEnemy.EnemyKilledChecker = CheckerKilledEnemy;
    }

    void OnGUI()
    {
        GUI.Box(new Rect(20, 50, 150, 25), "Enemy killed: " + CheckerKilledEnemy);
    }
}
