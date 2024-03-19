using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movment : MonoBehaviour
{
    //aplicar a fisica de movimento ao corpo do veiculo
    public Rigidbody2D carRig; //Cropo do veiculo
    public float speed; // responsavel pela velocidade
    private float movment; //direção do movimento (frente e ré)
    public Axle[] axles; //Definir a quantidade de eixos

    // Update is called once per frame
    void Update()
    {
        //Cpaturar o movimento horizontal
        //Setinha: <-  ->
        //WASD: A D
        //Controle: analogico EIXO X
        //DPAD: <-  ->
        movment = Input.GetAxis("Horizontal");
    }

    //Chamado a cada calculo da fisica
    void FixedUpdate()
    {
        //o movimento do eixo, é invertido
        //Se for para direita, recebe -1
        //Se for para esquerda, recebe 1
        //Realizamos a trativa, para ao receber o comando
        //da direita, o carro acelerar
        //Se velocidade positiva vai pra frente
        //se velocidade negativa vai para tras

        if(movment == -1)
            SetTorque(speed);        
        else if (movment == 1)
            SetTorque(-speed);
    }

    void SetTorque(float speed)
    {
        //Vai passar por cada eixo configurado
        //Ira calcular e aplicar o toque em cada eixo
        //Girando as rodas
        foreach(Axle axle in axles)
        {
            axle.wheel.AddTorque(speed * axle.torque * Time.fixedDeltaTime);
            //Aplicando o calulo para cada eixo aplicar a fisica contatraria
            //a fisica das rodas
            //ou seja se o carro for para frente
            //os roda iram girar no sentido horario
            //e o corpo do veiculo precisa girar no sentido 
            //antihorario
            carRig.AddTorque(-speed * axle.torque * Time.fixedDeltaTime);
        }
    }
}

//Responsavel por apresentar a config dentro da unity
[System.Serializable] 
//Class com um array de eixos
public class Axle
{
    public Rigidbody2D wheel;
    public float torque;
}
