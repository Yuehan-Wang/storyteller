using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ConversationManager : MonoBehaviour
{
    public Text ConversationText;
    public float typingSpeed = 0.05f;
    private string currentText = "Hi this is a lot of words that I am typing out to see if this works. I hope it does.";
    private bool isTyping = false;
    private Coroutine typingCoroutine;

    void Start()
    {
        typingCoroutine = StartCoroutine(TypeSentence(currentText));
    }

    IEnumerator TypeSentence(string sentence)
    {
        isTyping = true;
        ConversationText.text = "";
        foreach (char letter in sentence.ToCharArray())
        {
            ConversationText.text += letter;
            yield return new WaitForSeconds(typingSpeed);
        }
        isTyping = false;
    }

    public void CompleteTextAndStopTyping()
    {
        if (isTyping)
        {
            StopCoroutine(typingCoroutine);
            ConversationText.text = currentText;
            isTyping = false;
        }
    }

    public void LoadOfficeSceneIfTypingCompleted()
    {
        if (!isTyping)
        {
            PlayerPrefs.SetInt("DeliverBoyOutside", 0);
            PlayerPrefs.SetInt("NewspaperDisplayEval", 1);
            SceneManager.LoadScene("OfficeScene");
        }
    }
}
