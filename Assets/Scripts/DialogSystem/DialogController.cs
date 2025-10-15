using UnityEngine;
using TMPro;
using System.Collections;

public class DialogController : MonoBehaviour
{
    private TextMeshProUGUI dialogText;
    private string text = "aoshfdoiuahsfoiahfsoihaofhasoidfhsa aoshfdoiuahsfoiahfsoihaofhasoidfhsa aoshfdoiuahsfoiahfsoihaofhasoidfhsa aoshfdoiuahsfoiahfsoihaofhasoidfhsa aoshfdoiuahsfoiahfsoihaofhasoidfhsa ";

    private float currentCharactersPerSecond;
    [SerializeField] private float charactersPerSecond;
    [SerializeField] private float turboCharactersPerSecond;
    private void Awake()
    {
        currentCharactersPerSecond = charactersPerSecond;
        dialogText = GetComponent<TextMeshProUGUI>();
        StartCoroutine(ShowText());
    }

    private IEnumerator ShowText()
    {
        int i = 0;
        while (i <= text.Length)
        {
            dialogText.text = text.Substring(0, i);
            if (i < text.Length)
            {
                dialogText.text+=$"<color=#00000000>{text.Substring(i)}</color>";
            }
            i++;
            yield return new WaitForSeconds(1/currentCharactersPerSecond);
        }
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            currentCharactersPerSecond = turboCharactersPerSecond;
        }
        else
        {
            currentCharactersPerSecond = charactersPerSecond;
        }
    }

}
