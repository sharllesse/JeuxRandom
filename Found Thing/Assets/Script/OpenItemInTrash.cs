using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpenItemInTrash : MonoBehaviour
{
    public Image Image;
    public GameObject restoreThing;
    public GameObject restoreThings;

    public void OpenR()
    {
        Image.color = new Color32(54, 68, 183, 255);
        restoreThing.SetActive(true);
        restoreThings.SetActive(true);
    }
}
