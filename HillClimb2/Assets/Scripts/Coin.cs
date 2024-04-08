using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public int coinValue; //Variavel para definir o valor da moeda

    //Método para identificar a colisão entre
    //o carro e as moedas
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            CoinDisplay.instance.UpdateScore(coinValue);
            Destroy(gameObject);
        }
    }
}
