using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class personagem : MonoBehaviour
{
    /*public Vector3 valorInicial;
    float px, py;
    private float forcaPulo = 300;
    private Rigidbody2D rb;
    public float velocidade;
    public GameObject Tela_1, Tela_2;

    //Iniciar o jogo com Persogem e tela_01
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        transform.position = new Vector2(-8.82f, 0.21f);
        Instantiate(Tela_1, valorInicial, transform.rotation);

    }
    
    void Update()
    {
        
        float px = Input.GetAxisRaw("Horizontal") * velocidade * Time.deltaTime;
        float py = Input.GetAxisRaw("Vertical") * velocidade * Time.deltaTime;
        transform.Translate(px, py, 0.0f);
        
        if (Input.GetButtonDown("Jump"))
        {
            rb.AddForce(Vector2.up * forcaPulo);
        }
    }
   
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Cobra")
        {
            hud.vida--;
            transform.position = new Vector2(-4.96f, 0.93f);
        }


        if (collision.collider.tag == "Tela_1")
        {
            Instantiate(Tela_1, valorInicial, transform.rotation);
            transform.position = new Vector2(-8.82f, 0.21f);
        }
        if (collision.collider.tag == "Tela_2")
        {
            //Instantiate(,valorInicial,transform.rotation);
            //transform.position = new Vector2(-8.82f, 0.21f);
            //Destroy(GameObject.FindWithTag("Tela_1"));
        }
        if (collision.collider.tag == "Tela_3")
        {

        }
        if (collision.collider.tag == "Tela_1")
        {

        }
        if (collision.collider.tag == "Tela_2")
        {

        }
        if (collision.collider.tag == "Tela_3")
        {

        }
    }
             
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag == "Tronco_Parado")
        {
            hud.pontos--;
        }

    }
     
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Cair_Escada")
        {
            hud.pontos =hud.pontos -100;
            //px = 0;

        }
    }
    
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Cair_Escada")
        {
            //px = 5;
        }
        
    }
    */
  
}

