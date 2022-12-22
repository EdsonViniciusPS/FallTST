using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Web3WalletSendTransactionExample : MonoBehaviour
{
 async public void OnSendTransaction()
    {
        // https://chainlist.org/
        string chainId = "56"; // rinkeby
        // account to send to
        string to = "0xD4ea7E4C255e3A478A777daB92a816cc0be63224";
        // value in wei
        string value = "1000000000000000000";
        // data OPTIONAL
        string data = "";
        // gas limit OPTIONAL
        string gasLimit = "";
        // gas price OPTIONAL
        string gasPrice = "";
        // send transaction
        string response = await Web3Wallet.SendTransaction(chainId, to, value, data, gasLimit, gasPrice);
        print(response);
    }
}
