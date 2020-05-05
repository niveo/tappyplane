using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    public int pontuacao;

    public Text pontuacaoTexto;

    // Start is called before the first frame update
    void Start()
    {
        pontuacao = 0;
        this.mostrarPontos();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AumentarPontuacao()
    {
        pontuacao += 1;
        this.mostrarPontos();
    }

    private void mostrarPontos(){
        this.pontuacaoTexto.text = pontuacao.ToString();
    }
}
