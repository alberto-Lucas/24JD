using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;

public class CoinDisplay : MonoBehaviour
{
    public Text scoreCoin; //Variavel para vincular a label na HUD
    private int score; //Variavel utilizada para a contagem das moedas
    public static CoinDisplay instance; //Instancia da classe

    // Start is called before the first frame update
    void Start()
    {
        instance = this;
    }

    //Método para atualizar o valor
    //sempre que uma moeda for coletada
    //Recebe o valor da moeda coletada
    //por parametro
    public void UpdateScore(int value)
    {
        score += value;
        scoreCoin.text = score.ToString();
    }
}
