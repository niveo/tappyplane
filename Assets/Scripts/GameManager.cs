using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public int pontuacao;

    // Start is called before the first frame update
    void Start()
    {
        pontuacao = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AumentarPontuacao()
    {
        pontuacao += 1;
    }
}
