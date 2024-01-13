using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ConversationManager : MonoBehaviour
{
    public Text ConversationText;
    public float typingSpeed = 0.05f; 

    void Start()
    {
        string currentText = "Hi Editor, here is your news story. I hope you like it.";
        StartCoroutine(TypeSentence(currentText));
    }

    IEnumerator TypeSentence(string sentence)
    {
        ConversationText.text = "";
        float timer = 0f;
        int charIndex = 0;

        while (charIndex < sentence.Length)
        {
            timer += Time.deltaTime;
            if (timer >= typingSpeed)
            {
                ConversationText.text += sentence[charIndex];
                charIndex++;
                timer = 0f;
            }
            yield return null;
        }
    }
}
