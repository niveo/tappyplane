﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MontanhasEestrelas : MonoBehaviour
{
    public GameObject[] montanhas;

    public float tempoEntreAsMontanhas;

    public float tempoAtualMontanhas;

    public GameObject[] estrelas;

    public float tempoEntreAsEstrelas;

    public float tempoAtualEstrelas;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        tempoAtualMontanhas -= Time.deltaTime;
        if (tempoAtualMontanhas <= 0)
        {
            int montanhaAleatorio = Random.Range(0, montanhas.Length);
            Instantiate(montanhas[montanhaAleatorio], transform.position, transform.rotation);

            tempoAtualMontanhas = tempoEntreAsMontanhas;
        }

        tempoAtualEstrelas -= Time.deltaTime;
        if (tempoAtualEstrelas <= 0)
        {
            int estrelaAleatorio = Random.Range(0, estrelas.Length);
            Instantiate(estrelas[estrelaAleatorio], transform.position, transform.rotation);

            tempoAtualEstrelas = tempoEntreAsEstrelas;
        }
    }
}
