using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fuel : MonoBehaviour
{
    //Reconhecer a colisão entre 2 obejtos
    //Para colisão pelo um dos objetos
    //Precisa possuir um RigidyBody2d
    private void OnTriggerEnter2D(Collider2D collison)
    {
        //Verificar a colisão dos obejtos
        //Sendo um deles um objeto Player
        if(collison.CompareTag("Player"))
        {
            //Chamo método de recuperar combustivel
            //da classe FuelDisplay
            FuelDisplay.instance.AddFuel();

            //Remover o objeto da cena após coletado
            Destroy(gameObject);
        }
    }
}
