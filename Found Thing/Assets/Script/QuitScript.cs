using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitScript : MonoBehaviour
{
    public GameObject HackImage;
    public GameObject HackApp;
    public GameObject FicherGames;
    public void quit()
    {
        Application.Quit();
    }

    public void Restart()
    {
        HackImage.SetActive(false);
        HackApp.SetActive(false);
        FicherGames.SetActive(false);
    }
}
