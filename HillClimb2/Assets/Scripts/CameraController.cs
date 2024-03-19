using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform car; //Objeto Car
    public float followSpeed; //Velidade que a camera ira seguir o objeto
    Vector3 offset; //Movimenta��o da camera em cena

    //Vamos pegar a posi��o atual e a posi��o atual do veiculo
    //para criar a trajetoria e definir a velocidade que a camera
    //ira chegar no destino(veiculo)

    void Start()
    {
        //Sempre que o jogo iniciar
        //Iremos resetar as posi��es de camera
        //trasnform.position posi��o do objeto camera
        //car.position posi��o atual do objeto veiculo

        offset = transform.position - car.position;
    }

    void FixedUpdate()
    {
        transform.position =
            Vector3.Lerp(transform.position, //posi��o atual da camera
                        car.position + offset, //posi��o atual do veiculo + distancia da camera
                        followSpeed);        //a velocidade da camera
    }
}
