using UnityEngine;
using UnityEngine.SceneManagement;

public class StartSettings : MonoBehaviour
{

    public void LoadSettingsWindow()
    {
        SceneManager.LoadScene("SettingsScenes");
    }

}
