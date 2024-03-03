using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using System.Threading;
using UnityEngine;

public class Movimento : MonoBehaviour
{
    //Define a velocidade do movimento
    private float velocidade;
    //Vector para monipul��o a dire��o
    private Vector2 direcao;

    // Start is called before the first frame update
    void Start()
    {
        //Resetar o vetor de dire��o
        direcao = Vector2.zero;
        //Definir velocidade
        velocidade = 3;
    }

    // Update is called once per frame
    void Update()
    {
        InputPersonagem();
        transform.Translate(
            direcao * velocidade * Time.deltaTime);
    }

    //M�todo responsavel por captura a
    //dire��o de movimento
    void InputPersonagem()
    {
        direcao = Vector2.zero;

        if (Input.GetKey(KeyCode.UpArrow))
            direcao += Vector2.up;
        if (Input.GetKey(KeyCode.DownArrow))
            direcao += Vector2.down;
        if (Input.GetKey(KeyCode.LeftArrow))
            direcao += Vector2.left;
        if (Input.GetKey(KeyCode.RightArrow))
            direcao += Vector2.right;
    }
}
