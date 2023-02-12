using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    public void LoadGameScenes()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void ButtonPlay()
    {
        LoadGameScenes();
    }

}
