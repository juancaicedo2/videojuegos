using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoPlayer : MonoBehaviour
{

    void Start()
    {
        transform.position = new Vector3(0, 0, 0);

        Debug.Log("Pocision en X,Y,Z:" + transform.position); //imprimio en la consola el valor de la pocision del jugador
        Debug.Log("pocision en X:" + transform.position.x); //imprimio en consola el valor de la pocision del jugador en x

    }
     void Update()
    {
        //primero debemos logar que la nave se desplace
        //controlar elmovimoento de +x y -X
        //controlar el movimiento a la izq y a la der por medio del teclado
        //Validad que la tecla sirve para el desplazamiento a la izq y der

        transform.Translate(Vector3.right*Time.deltaTime);// Mov de translacion hacia la der
    }


}

