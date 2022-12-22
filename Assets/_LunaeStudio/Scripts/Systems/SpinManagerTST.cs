using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinManagerTST : MonoBehaviour
{
    public GameObject Player;

    public void TesteTrocarTag()
    {
        Player.tag = "PlayerDie";

        if (Player.CompareTag("PlayerDie"))
        {
            Debug.Log("Trocou");
        }
    }
}
