using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyPoro : MonoBehaviour
{
    public GameObject pad;
    public GameObject limiteInferior;
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "pad")
        {
            Score.puntaje++;
            Destroy(gameObject);
        }else if (collision.gameObject.tag == "limiteInferior")
        {
            vidas.vida--;
            Destroy(gameObject);
        }
        
    }

}
