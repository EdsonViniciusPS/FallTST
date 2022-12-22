using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAddress : MonoBehaviour
{
    public static string walletaddres;
    public GameObject stayWalletAddress;
    private void Awake()
    {
        //walletaddres = WalletLogin.account;
    }
    private void LateUpdate()
    {
        //Debug.Log(walletaddres);
        Stay();
    }

    private void Stay()
    {
        DontDestroyOnLoad(stayWalletAddress);
    }
}
