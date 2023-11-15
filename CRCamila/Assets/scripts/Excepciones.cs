using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Excepciones : MonoBehaviour
{
    int divide(int a, int b)
    {
        if (a==0)
        {
            throw new DivideByZeroException("No se puede dividir por 0.");
        }
        return a / b;
    }
    // Start is called before the first frame update
    void Start()
    {
        try
        {
            int result = divide(10, 0);
            Debug.Log("Resultado de la division: " + result);
        }
        catch (DivideByZeroException exception)
        {
            Debug.LogError("Error: division por cero: " + exception.Message);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
