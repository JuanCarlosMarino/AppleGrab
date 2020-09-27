using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour
{
    [SerializeField] public static int puntaje = 0;
    // Start is called before the first frame update
    void Start()
    {
        puntaje = 0;
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<UnityEngine.UI.Text>().text = puntaje.ToString();
        if (puntaje == 30)
        {
            SceneManager.LoadScene(2);
        }
    }
}
