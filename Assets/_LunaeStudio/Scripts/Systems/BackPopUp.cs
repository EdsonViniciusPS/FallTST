using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackPopUp : MonoBehaviour
{
    public GameObject PopUp;

    public void PopUpBack()
    {
        PopUp.SetActive(false);
    }
}
