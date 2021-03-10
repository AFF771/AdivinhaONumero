using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdivinhaONumero : MonoBehaviour
{
    [SerializeField] int minimiNoinicio = 20;
    [SerializeField] int maximoNoinicio = 80;

    int minimo; //declaração da variável
    int maximo; //declaração de variável
    int valorAAdivinhar;

    // Start is called before the first frame update
    void Start()
    {
        Iniciar();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            //Código a executar se o jogador pressionar a tecla para cima

            minimo= valorAAdivinhar;
            CalculaEImprime();

        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            //Código a executar se o jogador pressionar a tecla para baixo

            maximo = valorAAdivinhar;
            CalculaEImprime();

        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            //Código a executar se o jogador pressionar o Enter
            Debug.Log("O teu número é " + valorAAdivinhar + ". Viste como eu sou um génio?!");
            Debug.Log("O jogo vai ser reiniciado");
            Debug.Log("                          ");
            Debug.Log("                          ");
            Debug.Log("                          ");
            Debug.Log("                          ");

            Iniciar();
        }
    }

    void CalculaEImprime()          //MÉTODO OU FUNÇÃO
    {
        valorAAdivinhar = Random.Range(minimo , maximo);

        Debug.Log("Eu acho que o número em que pensaste é " + valorAAdivinhar);

        Debug.Log("Para responderes");
        Debug.Log("Seta Cima - o número em que pensaste é maior");
        Debug.Log("Seta Baixo - o número em que pensaste é menor");
        Debug.Log("Enter - o número em que pensaste é " + valorAAdivinhar + ".");
    }

    void Iniciar()
    {
        minimo = minimiNoinicio-1;   //este é o valor minimo do jogo
        maximo = maximoNoinicio+1; //este é o valor máximo do jogo

        Debug.Log("Olá, vamos jogar um jogo!");
        Debug.Log("Eu vou tentar adivinhar o número em que pensas");
        Debug.Log("Pensa então num número entre " + minimiNoinicio + " e " + maximoNoinicio);

        CalculaEImprime();
    }

     

}