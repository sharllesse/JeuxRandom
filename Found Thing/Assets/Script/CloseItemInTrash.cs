using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CloseItemInTrash : MonoBehaviour
{
    public Image Image;
    public GameObject folder;
    public GameObject folderSS;
    public GameObject folders;

    public void CloseR()
    {
        Image.color = new Color32(255, 255, 255, 255);
        folder.SetActive(false);
        folderSS.SetActive(false);
        folders.SetActive(false);
    }
}
