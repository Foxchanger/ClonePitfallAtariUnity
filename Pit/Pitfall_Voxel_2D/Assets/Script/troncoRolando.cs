using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class troncoRolando : MonoBehaviour {
    float velocidadeX = -5.0f;
    float velocidadeY = 0.0f;
    public float limiteX, retornarX;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(velocidadeX * Time.deltaTime, velocidadeY * Time.deltaTime, 0.0f);

        if (transform.position.x < limiteX)
        {
            transform.position = new Vector3(retornarX, 0.0f, 0.0f);
        }
    }

}
