using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using TMPro;

public class FileSystem : MonoBehaviour
{
    public GameObject obj;
    public bool isSavingPosition = false;
    public GameObject obj2;
    void CreateFile()
    {

    }

    void SaveObjectPosition(Transform _objTransform)

    {
        // 1) Acceder al path del archivo 
        string filename = "positions";
        string extension = ".txt";
        string path = Application.dataPath + "/Resources/" +
          filename + extension;
        // 2) Craer un archivo si no existe otro con el mismo nombre
        if (!File.Exists(path))
        {
            // 3) Escribir dentro del archivo 

            File.WriteAllText(path, "Hola");
        }
        // 4) Almacenar el contenido del archivo 
        string data = "Position: " + "(" 
            + _objTransform.position.x.ToString() + ","
            + _objTransform.position.y.ToString() + ","
            + _objTransform.position.z.ToString() + ","
            + "/n";

        // 5) Agregar la informacion del archivo
        File.AppendAllText(path, data);

        string ReadFile(string _fileName, string _extension)
        {
            // 1) Acceder al path del archivo
            string path = Application.dataPath + "/Resources/" + _fileName + _extension;
            // 2) Si el archivo existe, dame su info
            string data = " ";
            if (File.Exists(path)) 
            {
              data = File.ReadAllText(path);
            }
            return data;
        
        }
    }

    void Start()
    {
        //CreateFile();
        string data = ReadFile("example", ".txt");
        Debug.Log("Informacion del archivo: /n" + data);

        // Guarda la posicion en un nuevo archivo, 
        SaveObjectPosition(obj.transform);
        

        // Lee la info de ese archivo 
        int v;
        Vector3 pos;
        obj2.transform.position = pos;

        // asigna esos datos en un nuevo objeto 
        

    }

    void Update()
    {
        if (isSavingPosition) 
        {
            SaveObjectPosition(obj.transform);
        }
        
    }
}
