using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoroSpawn : MonoBehaviour
{
    [SerializeField]public float Tiempo_maximo;
    private float _timer = 0;
    public GameObject Poro;
    public GameObject Limite_Inferior;

    [SerializeField] public float Limite_derecho = 0;
    [SerializeField] public float Limite_izquierdo = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        GameObject newporo = Instantiate(Poro);
        newporo.transform.position = transform.position + new Vector3(Random.Range(-Limite_izquierdo,Limite_derecho), y:0,z:0);
    }

    // Update is called once per frame
    void Update()
    {
        if (_timer > Tiempo_maximo)
        {
            GameObject newporo = Instantiate(Poro);
            newporo.transform.position = transform.position + new Vector3(Random.Range(-Limite_izquierdo,Limite_derecho), y:0,0);
            Destroy(newporo,15);
            _timer = 0;

        }


        _timer += Time.deltaTime;
    }
}
