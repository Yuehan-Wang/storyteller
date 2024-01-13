using UnityEngine;

public class GameManager : MonoBehaviour
{
    public TitleEditor titleEditor;
    void Start()
    {
        InitializeGameSettings();
    }

    void InitializeGameSettings()
    {
        Debug.Log("game init");
        SetInitialTitle();
    }
    void SetInitialTitle()
    {
        string title = "this is a test title";
        titleEditor.SetTitle(title);
    }

}
