using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform car; //Objeto Car
    public float followSpeed; //Velidade que a camera ira seguir o objeto
    Vector3 offset; //Movimentação da camera em cena

    //Vamos pegar a posição atual e a posição atual do veiculo
    //para criar a trajetoria e definir a velocidade que a camera
    //ira chegar no destino(veiculo)

    void Start()
    {
        //Sempre que o jogo iniciar
        //Iremos resetar as posições de camera
        //trasnform.position posição do objeto camera
        //car.position posição atual do objeto veiculo

        offset = transform.position - car.position;
    }

    void FixedUpdate()
    {
        transform.position =
            Vector3.Lerp(transform.position, //posição atual da camera
                        car.position + offset, //posição atual do veiculo + distancia da camera
                        followSpeed);        //a velocidade da camera
    }
}
