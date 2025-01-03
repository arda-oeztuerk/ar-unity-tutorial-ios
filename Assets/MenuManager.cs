using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public void StartARExperience()
    {
        //AR Scene starten, wenn der Knopf gedrück wird
        SceneManager.LoadScene("SampleScene");
    }
}
