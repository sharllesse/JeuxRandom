using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectRestore : MonoBehaviour
{
    public Image restoreimage;
    public Image restoreimage2;
    public Image restoreimage3;
    public Image restoreimage4;

    public void AppRestore()
    {
        restoreimage.color = new Color32(54, 68, 183, 255);
        restoreimage2.color = new Color32(255,255, 255, 255);
        restoreimage3.color = new Color32(255, 255, 255, 255);
        restoreimage4.color = new Color32(255, 255, 255, 255);
    }
}
