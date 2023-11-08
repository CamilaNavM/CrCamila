using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class CardButton : MonoBehaviour
{
    public void EscenaJuego()
    {
        SceneManager.LoadScene("Playground");
    }
    public void CargarNivel(string nombreNivel)
    {
        SceneManager.LoadScene(nombreNivel);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
