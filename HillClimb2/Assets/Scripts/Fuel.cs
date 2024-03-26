using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fuel : MonoBehaviour
{
    //Reconhecer a colis�o entre 2 obejtos
    //Para colis�o pelo um dos objetos
    //Precisa possuir um RigidyBody2d
    private void OnTriggerEnter2D(Collider2D collison)
    {
        //Verificar a colis�o dos obejtos
        //Sendo um deles um objeto Player
        if(collison.CompareTag("Player"))
        {
            //Chamo m�todo de recuperar combustivel
            //da classe FuelDisplay
            FuelDisplay.instance.AddFuel();

            //Remover o objeto da cena ap�s coletado
            Destroy(gameObject);
        }
    }
}
