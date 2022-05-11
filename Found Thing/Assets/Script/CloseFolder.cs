using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CloseFolder : MonoBehaviour
{
    public GameObject closeWin;
    public Image Image;
    public Image Image1;

    public void closeWind()
    {
        closeWin.SetActive(false);
        Image.color = new Color32(255, 255, 255, 255);
        Image1.color = new Color32(255, 255, 255, 255);
    }
}
