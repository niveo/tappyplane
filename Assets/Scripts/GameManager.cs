using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    public int pontuacao;

    public Text pontuacaoTexto;

    public bool jogoPausado;

    public GameObject pausePainel;

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
            this.pausePainel.SetActive(false);
            Time.timeScale = 1f;
            this.jogoPausado = false;
        }
        else
        {
            this.pausePainel.SetActive(true);
            Time.timeScale = 0f;
            this.jogoPausado = true;
        }
    }

    private void mostrarPontos()
    {
        this.pontuacaoTexto.text = this.pontuacao.ToString();
    }

    public void CarregarTelaDeCreditos()
    {
        //Carregar tela de créditos

    }

    public void SairDoJog()
    {
        Debug.Log("Saiu do Jogo");
        Application.Quit();
    }

    public void MostrarTelaGameOver()
    {
        Debug.Log("GameOver");
        Time.timeScale = 0f;
    }

}
