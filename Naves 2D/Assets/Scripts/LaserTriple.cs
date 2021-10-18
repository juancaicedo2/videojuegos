using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserTriple : MonoBehaviour
{
    private float velDisparo = 10.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.up * velDisparo * Time.deltaTime);


        if (transform.position.y >= 6.42f)
        {
            Destroy(this.gameObject);
        }
    }
}
