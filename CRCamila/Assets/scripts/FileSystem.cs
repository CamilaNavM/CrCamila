using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using TMPro;

public class FileSystem : MonoBehaviour
{
    public GameObject obj;

    public bool isSavingPosition = false;
     void CreateFile()
    {
        //1) Acceder al path del archivo 
        string fileName = "Example";
        string extension = ".txt";
        string path = Application.dataPath + "/resources/" + fileName + extension;
        // 2) Crear un archivo, si no existe otro con el mismo nombre
        if (!File.Exists(path))
        {
            File.WriteAllText(path, "hola");
            
        }
        // 3) almacenar dentro del archivo
        string data = "Login Date: " + System.DateTime.Now + "\n";

        File.AppendAllText(path, data);
    }

    void SaveObjectPosition(Transform _objTransform) 
    {
        string fileName = "Position";
        string extension = ".txt";
        string path = Application.dataPath + "/resources/" + fileName + extension;
        // 2) Crear un archivo, si no existe otro con el mismo nombre
        if (!File.Exists(path))
        {
            File.WriteAllText(path, "hola");

        }
        // 3) almacenar dentro del archivo
        string data = "Position: " + "(" + _objTransform.position.x.ToString() + ", "
                                         + _objTransform.position.y.ToString() + ", "
                                         + _objTransform.position.z.ToString() + ", "
                                         + "\n";


        // 5) agregar la informacion al archivo
        File.AppendAllText(path, data);


    }
    
    string ReadFile(string _fileName, string _extension) 
    {
        // 1) Acceder al path del archivo
        string path = Application.dataPath + "/resources/" + _fileName + _extension;
        // 2) Si el archivo existe, dame su info 
        string data = "";

        if (File.Exists(path))
        {
            data = File.ReadAllText(path);
        }
        return data;
       
    }
     void Start()
    {
        //CreateFile();
        string data = ReadFile("example", ".txt");
        Debug.Log("Informacion del archivo: \n" + data);
    }

     void Update()
    {
        if (isSavingPosition)
        {
            SaveObjectPosition(obj.transform);
        }
        
    }
}
