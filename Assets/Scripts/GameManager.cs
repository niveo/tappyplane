using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    public int pontuacao;

    public Text pontuacaoTexto;

    public bool jogoPausado;

    // Start is called before the first frame update
    void Start()
    {
        this.pontuacao = 0;
        this.mostrarPontos();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            this.PausarJogo();
        }
    }

    public void AumentarPontuacao()
    {
        this.pontuacao += 1;
        this.mostrarPontos();
    }

    public void PausarJogo()
    {
        if (this.jogoPausado)
        {
            Time.timeScale = 1f;
            this.jogoPausado = false;
        }
        else
        {
            Time.timeScale = 0f;
            this.jogoPausado = true;
        }
    }

    private void mostrarPontos()
    {
        this.pontuacaoTexto.text = this.pontuacao.ToString();
    }
}
