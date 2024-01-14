using UnityEngine;

public class EditStartManager : MonoBehaviour
{
    public TitleEditor titleEditor;
    void Start()
    {
        SetInitialTitle();
    }
    void SetInitialTitle()
    {
        string title = "this is a test title for the game and this is very very long ahhhhhhhhhhhhhhh";
        titleEditor.SetTitle(title);
    }

}
