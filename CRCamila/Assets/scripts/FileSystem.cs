using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using TMPro;

public class FileSystem : MonoBehaviour
{
     void CreateFile()
    {
        //1) Acceder al path del archivo 
        string fileName = "example";
        string extension = ".txt";
        string path = Application.dataPath + "/resources/" + fileName + extension;
        // 2) Crear un archivo, si no existe otro con el mismo nombre
        if (!File.Exists(path))
        {
            File.WriteAllText(path, "hola");
            
        }
        // 3) almacenar dentro del archivo
        string data = "Login Date: " + System.DateTime.Now + "/n";
        //4) agregar informacion al archivo 
        File.AppendAllText(path, data);

    }

    private void Start()
    {
        CreateFile();
    }

    private void Update()
    {
        
    }
}
