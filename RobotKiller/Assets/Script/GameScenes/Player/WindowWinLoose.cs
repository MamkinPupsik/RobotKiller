using UnityEngine;

public class WindowWinLoose : MonoBehaviour
{
    public int CheckerKilledEnemy; 
    void OnGUI()
    {
        GUI.Box(new Rect(20, 50, 150, 25), "Enemy killed: " + CheckerKilledEnemy);
    }
}
