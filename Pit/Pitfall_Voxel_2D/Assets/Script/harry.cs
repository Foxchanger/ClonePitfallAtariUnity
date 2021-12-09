using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class harry : MonoBehaviour
{
    public string gameover;
    public float velocidade;
    public float forcaPulo;

    private AudioSource somPulo;
    //private AudioSource somDano;
    
    private Vector3 valorInicial;
    
    public GameObject player;

    private Rigidbody2D rb;

    private Animator anim;

    public Transform chaoVerificador;

    bool estaNoChao;
    //GameObject Todas as Telas(Cenarios)
    #region
    public GameObject Tela_1, Tela_2, Tela_3, Tela_4, Tela_5, Tela_6, Tela_7, Tela_8, Tela_9, Tela_10,
        Tela_11, Tela_12, Tela_13, Tela_14, Tela_15, Tela_16, Tela_17, Tela_18, Tela_19, Tela_20,
        Tela_21, Tela_22, Tela_23, Tela_24, Tela_25, Tela_26, Tela_27, Tela_28, Tela_29, Tela_30,
        Tela_31, Tela_32, Tela_33, Tela_34, Tela_35, Tela_36, Tela_37, Tela_38, Tela_39, Tela_40,
        Tela_41, Tela_42, Tela_43, Tela_44, Tela_45, Tela_46, Tela_47, Tela_48, Tela_49, Tela_50,
        Tela_51, Tela_52, Tela_53, Tela_54, Tela_55, Tela_56, Tela_57, Tela_58, Tela_59, Tela_60,
        Tela_61, Tela_62, Tela_63, Tela_64, Tela_65, Tela_66, Tela_67, Tela_68, Tela_69, Tela_70,
        Tela_71, Tela_72, Tela_73, Tela_74, Tela_75, Tela_76, Tela_77, Tela_78, Tela_79, Tela_80,
        Tela_81, Tela_82, Tela_83, Tela_84, Tela_85, Tela_86, Tela_87, Tela_88, Tela_89, Tela_90,
        Tela_91, Tela_92, Tela_93, Tela_94, Tela_95, Tela_96, Tela_97, Tela_98, Tela_99, Tela_100,
        Tela_101, Tela_102, Tela_103, Tela_104, Tela_105, Tela_106, Tela_107, Tela_108, Tela_109, Tela_110,
        Tela_111, Tela_112, Tela_113, Tela_114, Tela_115, Tela_116, Tela_117, Tela_118, Tela_119, Tela_120,
        Tela_121, Tela_122, Tela_123, Tela_124, Tela_125, Tela_126, Tela_127, Tela_128, Tela_129, Tela_130,
        Tela_131, Tela_132, Tela_133, Tela_134, Tela_135, Tela_136, Tela_137, Tela_138, Tela_139, Tela_140,
        Tela_141, Tela_142, Tela_143, Tela_144, Tela_145, Tela_146, Tela_147, Tela_148, Tela_149, Tela_150,
        Tela_151, Tela_152, Tela_153, Tela_154, Tela_155, Tela_156, Tela_157, Tela_158, Tela_159, Tela_160,
        Tela_161, Tela_162, Tela_163, Tela_164, Tela_165, Tela_166, Tela_167, Tela_168, Tela_169, Tela_170,
        Tela_171, Tela_172, Tela_173, Tela_174, Tela_175, Tela_176, Tela_177, Tela_178, Tela_179, Tela_180,
        Tela_181, Tela_182, Tela_183, Tela_184, Tela_185, Tela_186, Tela_187, Tela_188, Tela_189, Tela_190,
        Tela_191, Tela_192, Tela_193, Tela_194, Tela_195, Tela_196, Tela_197, Tela_198, Tela_199, Tela_200,
        Tela_201, Tela_202, Tela_203, Tela_204, Tela_205, Tela_206, Tela_207, Tela_208, Tela_209, Tela_210,
        Tela_211, Tela_212, Tela_213, Tela_214, Tela_215, Tela_216, Tela_217, Tela_218, Tela_219, Tela_220,
        Tela_221, Tela_222, Tela_223, Tela_224, Tela_225, Tela_226, Tela_227, Tela_228, Tela_229, Tela_230,
        Tela_231, Tela_232, Tela_233, Tela_234, Tela_235, Tela_236, Tela_237, Tela_238, Tela_239, Tela_240,
        Tela_241, Tela_242, Tela_243, Tela_244, Tela_245, Tela_246, Tela_247, Tela_248, Tela_249, Tela_250,
        Tela_251, Tela_252, Tela_253, Tela_254, Tela_255;
    #endregion
    
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = player.GetComponent<Animator>();
        transform.position = new Vector2(-6.91f, 4.57f);
        Instantiate(Tela_1, valorInicial, transform.rotation);
        valorInicial = new Vector3(0.0f, 0.0f, 0.0f);
        somPulo= GetComponent<AudioSource>();
        

    }

    // Update is called once per frame
    void Update()
    #region
    {


        hud.tempo = hud.tempo - 1;

        if(hud.tempo <= 0)
        {
            SceneManager.LoadScene(gameover);
        }
        
        if(hud.vida <= 0)
        {
            SceneManager.LoadScene(gameover);
        }

        float px = Input.GetAxisRaw("Horizontal") * velocidade * Time.deltaTime;
        //float py = Input.GetAxisRaw("Vertical") * velocidade * Time.deltaTime;
        transform.Translate(px, 0.0f, 0.0f);

        //Pulo
        if (Input.GetButtonDown("Jump") && estaNoChao)
        {
            rb.AddForce(Vector2.up * forcaPulo);
            somPulo.Play();

        }
        //virar persoangem 
        if (Input.GetAxisRaw("Horizontal") > 0)
        {
            player.transform.eulerAngles = new Vector2(0.0f, 0.0f);

        }
        else if (Input.GetAxisRaw("Horizontal") < 0)
        {
            player.transform.eulerAngles = new Vector2(0.0f, 180.0f);
        }

        //Verificar colisao com o chao.
        estaNoChao = Physics2D.Linecast(transform.position, chaoVerificador.transform.position,
            1 << LayerMask.NameToLayer("Chao"));

        // Animação
        anim.SetBool("pulando", estaNoChao);
        anim.SetFloat("movimento", Mathf.Abs(Input.GetAxisRaw("Horizontal")));
        //anim.SetFloat("movimentoY", Mathf.Abs(Input.GetAxisRaw("Vertical")));
        #endregion
    }
    // Inicir Proximos Cenarios ou Cenarios Anteriores
    #region
    private void OnCollisionEnter2D(Collision2D c)
    {
        if (c.collider.tag == "Tela_1")
        {
            Instantiate(Tela_1, valorInicial, transform.rotation);
            transform.position = new Vector2(11.09609f, -0.7188465f);
            Destroy(GameObject.FindWithTag("Tela_2"));
        }

        if (c.collider.tag == "Tela_2")
        {
            Instantiate(Tela_2, valorInicial, transform.rotation);
            transform.position = new Vector2(-10.9624f, -0.7188463f);
            Destroy(GameObject.FindWithTag("Tela_1"));
        }

        if (c.collider.tag == "Tela_3")
        {
            Instantiate(Tela_3, valorInicial, transform.rotation);
            transform.position = new Vector2(-10.9624f, -0.7188463f);
            Destroy(GameObject.FindWithTag("Tela_2"));
        }

        if (c.collider.tag == "Tela_4")
        {
            Instantiate(Tela_3, valorInicial, transform.rotation);
            transform.position = new Vector2(-10.9624f, -0.7188463f);
            Destroy(GameObject.FindWithTag("Tela_3"));
        }




        #endregion
        //////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////

        if (c.collider.tag == "Cobra")
        {
            hud.vida--;
            transform.position = new Vector2(-4.96f, 0.93f);
        }
    }

    private void OnTriggerStay2D(Collider2D c)
    {
        if (c.tag == "Tronco_Parado")
        {
            hud.pontos--;
            

        }
    }
    private void OnTriggerEnter2D(Collider2D c)
    {
        if (c.tag == "Cair_Escada") 
        {
            hud.pontos = hud.pontos - 100;
        }
         
        if (c.tag == "Buraco") 
        {
            hud.pontos = hud.pontos - 100;
        }

        if (c.tag == "Piche")
        {
            transform.position = new Vector2(-9.34f, 4.08f);
            hud.vida--;
        }

    }
}