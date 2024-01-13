using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class TitleEditor : MonoBehaviour
{
    public GameObject wordPrefab;
    public Transform wordsContainer; 
    public Color normalColor = Color.white;
    public Color toggledColor = Color.black;


    private List<GameObject> wordObjects = new List<GameObject>();
    private Dictionary<GameObject, bool> isRemoved = new Dictionary<GameObject, bool>();


    public void SetTitle(string title)
{
    foreach (GameObject wordObj in wordObjects)
    {
        Destroy(wordObj);
    }
    wordObjects.Clear();
    isRemoved.Clear();
    string[] words = title.Split(' ');
    foreach (string word in words)
    {
        GameObject wordObj = Instantiate(wordPrefab, wordsContainer);
        Text wordText = wordObj.GetComponentInChildren<Text>();
        Button wordButton = wordObj.GetComponentInChildren<Button>();

        if (wordText != null && wordButton != null)
        {
            wordText.text = word;
            wordButton.onClick.AddListener(() => ToggleWord(wordObj));

            wordObjects.Add(wordObj);
            isRemoved[wordObj] = false;
        }
        else
        {
            Debug.LogError("Prefab does not contain a Text or Button component.");
        }
    }
}




    void ToggleWord(GameObject wordObj)
    {
        Text wordText = wordObj.GetComponentInChildren<Text>();
        if (wordText != null)
        {
            if (isRemoved[wordObj])
            {
                wordText.color = normalColor;
                isRemoved[wordObj] = false;
            }
            else
            {
                wordText.color = toggledColor;
                isRemoved[wordObj] = true;
            }
        }
    }
}
