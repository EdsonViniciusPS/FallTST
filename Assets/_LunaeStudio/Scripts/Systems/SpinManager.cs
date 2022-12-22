using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Photon.Pun;

public class SpinManager : MonoBehaviour
{
    
    public static int counter;
    
    private void Awake()
    {
        SpinBattleCounter();
        
    }

    [PunRPC]
    void SpinBattleCounter()
    {
        counter = 4;
    }

    
}
