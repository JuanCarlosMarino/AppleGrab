using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class vidas : MonoBehaviour
{
    [SerializeField] public static int vida = 3;
    // Start is called before the first frame update
    void Start()
    {
        vida = 3;
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<UnityEngine.UI.Text>().text = vida.ToString();
        if (vida == 0)
        {
            SceneManager.LoadScene(3);
        }
    }
}
