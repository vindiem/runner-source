using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class textAnim : MonoBehaviour
{
    public Text TextGameObjects;
    private string text;

    public GameObject StorePanel;

    private void Start()
    {
        text = TextGameObjects.text;
        TextGameObjects.text = "";
        StartCoroutine(TextCroutine());
    }

    IEnumerator TextCroutine()
    {
        foreach (char abc in text)
        {
            TextGameObjects.text += abc;
            yield return new WaitForSeconds(0.15f);
        }
    }

    public void EnterButton()
    {
        SceneManager.LoadScene("game");
    }
}
