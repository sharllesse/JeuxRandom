using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class OpenFolder : MonoBehaviour
{
    public Image Image;
    public GameObject Folder;
    public void OpenF()
    {
        Image.color = new Color32(54, 68, 183, 255);
        Folder.SetActive(true);
    }
}
