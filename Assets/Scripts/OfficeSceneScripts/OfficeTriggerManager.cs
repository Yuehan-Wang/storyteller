using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OfficeTriggerManager : MonoBehaviour
{
    public GameObject doorOpen;
    public GameObject doorClose;
    public GameObject DeliverBoy;

    public GameObject Newspaper;

    public bool DeliverBoyOutside;
    public bool NewspaperDisplayEval;

    void Start()
    {
        DeliverBoyOutside = PlayerPrefs.GetInt("DeliverBoyOutside") == 1;
        NewspaperDisplayEval = PlayerPrefs.GetInt("NewspaperDisplayEval") == 1;
        Newspaper.SetActive(false);
        doorOpen.SetActive(false);
        doorClose.SetActive(true);
        NewspaperDisplay();
    }


    public void EditSceneTrigger()
    {
        SceneManager.LoadScene("EditScene");
    }

    public void DoorTrigger()
    {
        if (doorOpen.activeSelf == true)
        {
            doorOpen.SetActive(false);
            doorClose.SetActive(true);
        }
        else
        {
            doorOpen.SetActive(true);
            doorClose.SetActive(false);
            if (DeliverBoyOutside)
            {
                DeliverBoy.SetActive(true);
            }
            else
            {
                DeliverBoy.SetActive(false);
            }
        }
        
    }

    void NewspaperDisplay()
    {
        if(NewspaperDisplayEval)
        {
            Newspaper.SetActive(true);
        }
        else
        {
            Newspaper.SetActive(false);
        }
    }

    public void HallwaySceneTrigger()
    {
        SceneManager.LoadScene("HallwayScene");
    }
}
