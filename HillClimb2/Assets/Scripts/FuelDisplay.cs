using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class FuelDisplay : MonoBehaviour
{   //Iremos vincular a barra de
    //progresso do combustivel
    public Image fuel;

    //Instancia para acessar esta classe
    //atraves de outra classe
    public static FuelDisplay instance;

    // Start is called before the first frame update
    void Start()
    {
        //Vinculamos esta classe a instancia
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        //Ao acelera o veiculo
        //A barra ira diminuir

        //Aplicar calculo para que o retorno
        //seja sempre positivo
        //pois o valor negativo ira recuperar 
        //o combustivel
        fuel.fillAmount -= Math.Abs(Input.GetAxis("Horizontal")/100f);
    }

    //Metodo para recuperar o combustivel
    public void AddFuel()
    {
        //fuel.fillAmount += 0.1f //Adicionar 10%

        fuel.fillAmount = 1; //Recuperando totalmente
    }

    //Metodo para retornar
    //a quantidade de combustivel atual
    public float GetFuel()
    {
        return fuel.fillAmount;
    }
}
