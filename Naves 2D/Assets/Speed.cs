using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Speed : MonoBehaviour
{
    private float velocidadUp = 3.5f;
    
    void Start()
    {
        transform.Translate(Vector3.down * velocidadUp * Time.deltaTime);
    }


    void Update()
    {
        transform.Translate(Vector3.down * velocidadUp * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        MovJugador nave = other.GetComponent<MovJugador>();
        nave.velocidad = 10f;
        nave.velocidadUp = 10f;
        Destroy(this.gameObject);
    }
}
