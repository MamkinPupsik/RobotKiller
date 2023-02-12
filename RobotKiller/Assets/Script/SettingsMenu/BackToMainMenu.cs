using UnityEngine.SceneManagement;
using UnityEngine;

public class BackToMainMenu : MonoBehaviour
{
    public void BackToMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
