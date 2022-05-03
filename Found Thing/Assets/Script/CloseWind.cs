using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CloseWind : MonoBehaviour
{
    public GameObject closeWin;
    public Image Image;

    public void closeWind()
    {
        closeWin.SetActive(false);
        Image.color = new Color32(255, 255, 255, 255);
    }
}
