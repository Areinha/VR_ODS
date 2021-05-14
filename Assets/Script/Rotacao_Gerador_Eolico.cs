using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotacao_Gerador_Eolico : MonoBehaviour
{
    public bool EixoY;
    public bool EixoX;
    public bool EixoZ;

    public float Velocidade = 0f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (EixoX == true)
        {
            transform.Rotate(Time.deltaTime * Velocidade, 0, 0, Space.Self);
        }

        if (EixoY == true)
        {
            transform.Rotate(0, 0, Time.deltaTime * Velocidade, Space.Self);
        }

        if (EixoZ == true)
        {
            transform.Rotate(0, Time.deltaTime * Velocidade,0, Space.Self);
        }

    }
}
