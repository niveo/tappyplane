﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Estrelas : MonoBehaviour
{
   private void OnTriggerEnter2D(Collider2D other) {
       if(other.gameObject.CompareTag("Player")){
           FindObjectOfType<GameManager>().AumentarPontuacao();

           Destroy(this.gameObject);
       }
   }
}