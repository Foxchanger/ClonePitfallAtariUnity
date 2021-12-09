using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class inicio : MonoBehaviour
{

    
    public Button botaoInicio;
    Button btn;

    void Start()
    {
        btn = botaoInicio.GetComponent<Button>();
        btn.onClick.AddListener(EntrarNoJogo);
    }
    void EntrarNoJogo()
    {
        SceneManager.LoadScene("Tela_01");
    }
    // Update is called once per frame
    void Update()
    {

    }
}
