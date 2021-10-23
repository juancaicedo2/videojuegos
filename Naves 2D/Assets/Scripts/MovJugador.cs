using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovJugador: MonoBehaviour
{
    public float velocidad;
    public float movimientoHorizontal;
    public float movimientoVertical;
    public float velocidadUp;
    public int vidasJugador = 3;
    public GameObject disparoL;
    public GameObject disparoLT;
    public bool disparoTriple=true;
    void Start()
    {
        velocidad = 5.0f; 
        velocidadUp = 8.0f;
       

    }


    void Update()
    {

        movimientoPersonaje();

        disparoPersonaje();

        disparoPersonajeTriple();
    }

     void movimientoPersonaje()
     {
        //primero debemos logar que la nave se desplace
        //controlar elmovimoento de +x y -X
        //controlar el movimiento a la izq y a la der por medio del teclado
        //Validad que la tecla sirve para el desplazamiento a la izq y edl


        movimientoHorizontal = Input.GetAxis("Horizontal"); //captura el valor de la tecla en el eje horizontal
        transform.Translate(Vector3.right * Time.deltaTime * velocidad * movimientoHorizontal);// Mov de translacion hacia la der


        movimientoVertical = Input.GetAxis("Vertical"); //captura el valor de la tecla en el eje vertical
        transform.Translate(Vector3.up * Time.deltaTime * movimientoVertical * velocidadUp);

        //Restringir el movimiento del player al escenario

        if(transform.position.y > 5.83f )
        {
            transform.position = new Vector3(transform.position.x, 5.83f, transform.position.z);
        }

        if(transform.position.y < -2.45f )
        {
            transform.position = new Vector3(transform.position.x, -2.45f, transform.position.z);
        }

        if(transform.position.x > 7.97f)
        { 
            transform.position = new Vector3(7.97f, transform.position.y, transform.position.z);
        }
        
        if(transform.position.x < -8.67f)
        {
            transform.position = new Vector3(-8.67f, transform.position.y, transform.position.z);
        }

    }

    void disparoPersonaje()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            Instantiate(disparoL, transform.position + new Vector3(0, 0, -0.82f), Quaternion.identity);
           // Instantiate(disparoL, transform.position + new Vector3(0, 1.5f, -0.82f), Quaternion.identity);
          //  Instantiate(disparoL, transform.position + new Vector3(0, 3f, -0.82f), Quaternion.identity);
        }
    }
    void disparoTriple()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            Instantiate(disparoL, transform.position + new Vector3(0, 0, -0.82f), Quaternion.identity);
            Instantiate(disparoL, transform.position + new Vector3(0, 1.5f, -0.82f), Quaternion.identity);
            Instantiate(disparoL, transform.position + new Vector3(0, 3f, -0.82f), Quaternion.identity);
        }
        else if (Input.GetKey(KeyCode.Space))
        {
            Instantiate(distamce
        }
    }

    void disparoPersonajeTriple()
    {
        if(Input.GetKey(KeyCode.Z))
        {
            Instantiate(disparoLT, transform.position + new Vector3(0, 1.5f, -0.82f), Quaternion.identity);
        }
    }

}
