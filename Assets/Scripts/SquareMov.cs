using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MovimientoCuadrado : MonoBehaviour
{
    public float velocidad = 25.0f; // Velocidad de movimiento
    public float margen = 0.5f;   // Margen de seguridad para que el obj
    void Update()
    {
        
        // Obtén la entrada del jugador en el eje horizontal y vertical
        float movimientoHorizontal = Input.GetAxis("Horizontal");
        float movimientoVertical = Input.GetAxis("Vertical");

        // Calcula el vector de movimiento
        Vector3 movimiento = new Vector3(movimientoHorizontal, movimientoVertical, 0.0f);

        // Normaliza el vector para mantener la misma velocidad en todas las direcciones
        movimiento.Normalize();
        // Calcula la nueva posición del objeto sumando el movimiento
        Vector3 nuevaPosicion = transform.position + movimiento * velocidad * Time.deltaTime;

          // Limita la posición del objeto a los límites de la pantalla
        nuevaPosicion.x = Mathf.Clamp(nuevaPosicion.x, 
            Camera.main.ScreenToWorldPoint(Vector3.zero).x + margen,
            Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, 0, 0)).x - margen);
        nuevaPosicion.y = Mathf.Clamp(nuevaPosicion.y, 
            Camera.main.ScreenToWorldPoint(Vector3.zero).y + margen,
            Camera.main.ScreenToWorldPoint(new Vector3(0, Screen.height, 0)).y - margen);

         // Aplica la nueva posición al objeto cuadrado
        transform.position = nuevaPosicion;
        // Aplica el movimiento al objeto cuadrado
        //transform.Translate(movimiento * velocidad * Time.deltaTime);
        //print("hola");
    }
    void OnCollisionEnter2D(Collision2D collision)
{
    if (collision.gameObject.CompareTag("Circle")) // Cambia "Circle" por la etiqueta adecuada del objeto circular
    {
       
        print("hola Pendejo");
        // Aquí puedes agregar código para manejar la colisión con el objeto circular.
        // Por ejemplo, puedes detener el movimiento del cuadrado o realizar cualquier acción deseada.
    }
}

}


/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SquareMov : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}*/
