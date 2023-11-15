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

    int GetArrayValue(int[] array, int index)
    {
        if(index < 0 || index >= array.Length) 
        {
            throw new IndexOutOfRangeException("indice fuera de rango. Checate");
        }
        return array[index];
    }

    int CastStringToInt(string _str)
    {
        return int.Parse(_str);
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

        //acces to an invalid index
        try
        {
            int[] array = { 1, 2, 3, 4, 5, 6, };
            int val = GetArrayValue(array, 7);
            Debug.Log("Valor obtenido: " + val);
        }
        catch (IndexOutOfRangeException ex2)
        {
        Debug.LogError("Error: Indice fuera de rango. Detalles: " + ex2.Message);
        }

        try
        {
            string str = "pepe";
            int result = CastStringToInt(str);
            Debug.Log("Numero convertido: " + result);
        }
        catch(FormatException ex3)
        {
            Debug.LogError("Error: Formato incorrecto. Detalles: " + ex3.Message);
        }
        catch(Exception ex4)
        { 
        Debug.LogError("Error general. Detalles: "+ ex4.Message);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
