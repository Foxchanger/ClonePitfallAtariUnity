using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class cenaInicio : MonoBehaviour {
    public string cena;

	void Update () {
        if (Input.anyKeyDown)
        {
            SceneManager.LoadScene(cena);
        }
	}
}
