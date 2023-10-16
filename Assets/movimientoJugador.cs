using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimientoJugador : MonoBehaviour
{
    private Rigidbody2D rb2D;
    [Header("Movimiento")]
    private float movimientoHorizontal=0f;
    /*Apareceran en el inspector por [SerializeField]*/
    [SerializeField] private float velocidadMovimiento;//velocidad del jugador

    //con [Range(0,0.3)] en el inspector nos aparece una barra para medir dichos valores
    [Range(0,0.3f)][SerializeField] private float suavizadoDeMovimiento;//recomendado valores entre 0 y 0.3
    /**/
    private Vector3 velocidad = Vector3.zero;
    private bool mirandoDerecha = true;

    //Encabezado por el orden
    [Header("Salto")]
    [SerializeField] private float fuerzaDeSalto;
    [SerializeField] private LayerMask queEsSuelo;//para identificar superficies aptas para que el personaje salte

    //objeto que el personaje tendra en los pies para generar el objeto(una caja alrededor de este objeto) 
    //esta caja dara informacion si estamos en el suelo o no
    [SerializeField] private Transform controladorSuelo;

    [SerializeField] private Vector3 dimensionesCaja;
    [SerializeField] private bool enSuelo;//tendra la informacion sobre si estamos en el suelo
    private bool salto = false;//variable para poder saltar

    [Header("Animacion")]
    private Animator animator;
    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
        animator=GetComponent<Animator>();
    }

    void Update()
    {
        movimientoHorizontal = Input.GetAxisRaw("Horizontal") * velocidadMovimiento;

        animator.SetFloat("Horizontal", Mathf.Abs(movimientoHorizontal));

        //condicional si apretamos el boton (predefinido en unity Jump = barra espaciadora) barra espaciadora, cambia el valor de salto
        if (Input.GetButtonDown("Jump"))
        {
            salto=true;
        }
    }
    //funcion para que funcione igual en pc comunes o potentes
    private void FixedUpdate() 
    {
        /*enSuelo indicamos que mientras la caja toque algo, que sea suelo*/
        enSuelo = Physics2D.OverlapBox(controladorSuelo.position, dimensionesCaja, 0f, queEsSuelo);
        
        animator.SetBool("enSuelo",enSuelo);
        
        Mover(movimientoHorizontal * Time.fixedDeltaTime, salto);
        //para que no siempre se mande la señal de saltar
        salto = false;
    }
    //se le agrega bool saltar al metodo Mover, y tambien se debe cambiar en el parametro cuando llamamos a la funcion Mover en FixedUpdate
    private void Mover(float mover, bool saltar)
    {
        //en X la velocidad que tenemos "mover", y en Y la del mismo ribidBody
        //con esto no se altera la velocidad cuando cae o salta (en eje Y)
        Vector3 velocidadObjetivo = new Vector2(mover, rb2D.velocity.y);

        //funcion smoothDamp da una suavidad cuando acelera o frena el personaje
        //parametros (vel en la que estamos, vel a la que deseamos llegar, vel que tan rapido)
        rb2D.velocity = Vector3.SmoothDamp(rb2D.velocity, velocidadObjetivo, ref velocidad, suavizadoDeMovimiento);

        //condicional para comprobar si el personaje VE para donde nos movemos y sino se gira
        if (mover>0 && !mirandoDerecha)
        {
            Girar();
        }
        else if (mover<0 && mirandoDerecha)
        {
            Girar();
        }
        /*condicional si el personaje esta en el suelo y se presiona saltar*/
        if (enSuelo && saltar)
        {
            //se cambia enSuelo a false
            enSuelo = false;
            //y se agrega una fuerza en X=0, y en Y la fuerzaDeSalto(que se podra regular en el inspector)
            rb2D.AddForce(new Vector2(0f, fuerzaDeSalto));
        }
    }
    private void Girar()
    {
        //cambia la variable al sentido contrario, si es falsa=verdadera y viceversa
        mirandoDerecha = !mirandoDerecha;
        Vector3 escala = transform.localScale;
        //se cambia la posicion del personaje multiplicando por -1
        escala.x *= -1;
        transform.localScale = escala;
    }
    /*nos permite ver la caja que creamos(invisible en el juego) para guiarnos la vamos a visualizar por este metodo*/
    private void OnDrawGizmos() 
    {
        Gizmos.color = Color.yellow;//le damos color amarrillo
        //con este metodo de unity, dibujamos la caja (posicion para dibujarla, dimensiones)
        Gizmos.DrawWireCube(controladorSuelo.position, dimensionesCaja);
    }
}
