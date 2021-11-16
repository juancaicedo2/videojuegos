using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tripleShot : MonoBehaviour
{
    private float velocidadUp = 3.5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.down * velocidadUp * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        MovJugador nave = other.GetComponent<MovJugador>();
        nave.disparoTriple = true;
        Destroy(this.gameObject);
    }
}
