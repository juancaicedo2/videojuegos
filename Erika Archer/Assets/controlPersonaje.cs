using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controlPersonaje : MonoBehaviour
{
   //animator Controller

    public float velocidadP=20.0f;
    public float rotateP = 50.0f;
    public float px;
    public float py;
    public Animator miAnim;
    void Start()
    {
        miAnim = GetComponent<Animator>();  
    }

  
    void Update()
    {

        //capturar eventos del teclado

        px= Input.GetAxis("Horizontal");
        py= Input.GetAxis("Vertical");

        transform.Translate(0, 0, py * Time.deltaTime * velocidadP);

        //Calcular el desplazamiento para girar

        transform.Rotate(0, px * Time.deltaTime * rotateP, 0);

        //accerder al controller

        miAnim.SetFloat("velX", px);
        miAnim.SetFloat("velY", py);
    }
}
