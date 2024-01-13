using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OfficeTriggerManager : MonoBehaviour
{
    public GameObject doorOpen;
    public GameObject doorClose;

    void Start()
    {
    
        doorOpen.SetActive(false);
        doorClose.SetActive(true);
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
        }
    }
}
