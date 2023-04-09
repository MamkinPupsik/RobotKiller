using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class TextDeathAnim : MonoBehaviour
{
    public GameObject buttonMenu;
    public GameObject buttonQuit;
    public Text TextGameObject;
    public GameObject TextCursor;
    public string text;

    private void Start()
    {
        text = TextGameObject.text;
        TextGameObject.text = "";
        StartCoroutine(TextCoroutine());
    }

    IEnumerator TextCoroutine()
    {
        foreach(char abc in text)
        {
            TextGameObject.text += abc;
            yield return new WaitForSeconds(0.3f);
        }
        buttonMenu.SetActive(true);
        buttonQuit.SetActive(true);
        yield return new WaitForSeconds(1f);
        TextCursor.SetActive(true);
    }
}
