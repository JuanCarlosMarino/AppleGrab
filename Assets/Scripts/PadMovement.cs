using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PadMovement : MonoBehaviour
{
    [Tooltip("Velocidad en unidades de unity: ")] [SerializeField]
    private float velocity = 1f;
    
    [Header("Controles para el pad")] 
    [SerializeField] public KeyCode leftControl;
    [SerializeField] public KeyCode rightControl;

    private Rigidbody2D _rigidbody2D;

    public Vector2 posicionInicial;
    // Start is called before the first frame update
    void Start()
    {
        posicionInicial = transform.position;
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(leftControl))
        {
            transform.Translate(-velocity,0f,0f);
        }else if (Input.GetKey(rightControl))
        {
            transform.Translate(velocity,0f,0f);
        }
    }
}
