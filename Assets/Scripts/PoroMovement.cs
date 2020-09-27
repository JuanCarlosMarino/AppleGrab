using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoroMovement : MonoBehaviour
{
    [SerializeField] private float VelocidadMin = 1f;
    [SerializeField] private float VelocidadMax = 5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.down * Random.Range(VelocidadMin,VelocidadMax) * Time.deltaTime;
    }
}
