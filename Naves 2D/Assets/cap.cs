using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cap : MonoBehaviour
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
}
