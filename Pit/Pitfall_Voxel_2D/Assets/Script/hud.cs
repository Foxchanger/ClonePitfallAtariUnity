using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class hud : MonoBehaviour {

    public Text txtVida;
    public Text txtPontos;
    public Text txtTime;

    public static int  vida;
    public static int pontos;
    public static int tempo;
	
	void Start () {

        vida = 2;
        pontos = 2000;
        tempo = 30000;
        
	}
	
	
	void Update () {
        txtPontos.text = pontos.ToString();
        txtVida.text = vida.ToString();
        txtTime.text = tempo.ToString();
    }
}
