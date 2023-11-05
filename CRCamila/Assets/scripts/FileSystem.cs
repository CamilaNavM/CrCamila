using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class FileSystem : MonoBehaviour
{
    public GameObject obj;
    public bool isSavingPosition = false;
    v
    

    void SaveObjectPosition(Transform _objTransform)

    {
        // 1) Acceder al path del archivo 
        string filename = "positions";
        string extension = ".txt";
        string path = Application.dataPath + "/Resources/" +
          filename + extension;
        // 2) Craer un archivo si no existe otro con el mismo nombre
        if (File.Exists(path))
        {
            // 3) Escribir dentro del archivo 

            File.WriteAllText(path, "Hola");
        }
        // 4) Almacenar el contenido del archivo 
        string data = "Position: " + "(" + _objTransform.position.x.ToString() + ","
            + _objTransform.position.y.ToString() + ","
            + _objTransform.position.z.ToString() + ","
            + "/n";

        // 5) Agregar la informacion del archivo
        File.AppendAllText(path, data);
    }

   // private void Start()
    /// <summary>
    /// {
    /// </summary>
      //  CreateFile();
    // }

    private void Update()
    {
        if (isSavingPosition) 
        {
            SaveObjectPosition(obj.transform);
        }
        
    }
}
