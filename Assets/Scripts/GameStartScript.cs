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
        string title = "this is a test title for the game and this is very very long ahhhhhhhhhhhhhhh";
        titleEditor.SetTitle(title);
    }

}
