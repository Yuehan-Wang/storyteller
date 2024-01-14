using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameStartManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        InitializeGameSettings();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void InitializeGameSettings()
    {

        PlayerPrefs.SetInt("DeliverBoyOutside", 1);
        PlayerPrefs.SetInt("NewspaperDisplayEval", 0);


        PlayerPrefs.SetInt("Tyranny", 0);
        PlayerPrefs.SetInt("Anarchy", 0);

        PlayerPrefs.SetInt("TyrannyEnding", 0);
        PlayerPrefs.SetInt("AnarchyEnding", 0);
        PlayerPrefs.SetInt("BoringEnding", 0);
    }

    public void StartGame()
    {
        SceneManager.LoadScene("OfficeScene");
    }
}
