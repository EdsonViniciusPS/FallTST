using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedesLunae : MonoBehaviour
{
    public string URL_Telegram;
    public void Telegram()
    {
        Application.OpenURL(URL_Telegram);
    }
}
