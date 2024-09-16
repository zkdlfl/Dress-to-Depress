using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClosetExist : MonoBehaviour

{
    public GameObject ClosetPanelUI;
    public void onExistButtonClick()
    {
        if (ClosetPanelUI != null)
        {
            ClosetPanelUI.SetActive(false);
            Debug.Log("Closet closed.");
        }
    }

}
