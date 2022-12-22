using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{

    public enum TipoRot { GirarEmX, GirarEmY, GirarEmZ };
    public TipoRot EixoDeRotacao = TipoRot.GirarEmY;
    public float velGiro = 10;
    public float velDesaceleracao = 3;
    public bool comecarGirando = true;
    public KeyCode Tecla = KeyCode.E;

    bool girar = false;
    bool desativar = false;
    float velC = 1;

    void Start()
    {
        girar = comecarGirando;
        desativar = false;
        velC = 1;
    }

    void Update()
    {
        if (Input.GetKeyDown(Tecla))
        {
            desativar = true;
        }
        if (desativar)
        {
            velC -= Time.deltaTime * velDesaceleracao * 0.1f;
        }
        if (girar)
        {
            if (velC <= 0)
            {
                girar = false;
            }
            switch (EixoDeRotacao)
            {
                case TipoRot.GirarEmX:
                    transform.Rotate(velGiro * 10 * velC * Time.deltaTime, 0, 0);
                    break;
                case TipoRot.GirarEmY:
                    transform.Rotate(0, velGiro * 10 * velC * Time.deltaTime, 0);
                    break;
                case TipoRot.GirarEmZ:
                    transform.Rotate(0, 0, velGiro * 10 * velC * Time.deltaTime);
                    break;
            }
        }
    }
}
