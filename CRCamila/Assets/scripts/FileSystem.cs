using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using TMPro;

public class FileSystem : MonoBehaviour
{
    public GameObject obj;
    public GameObject obj2;
    public bool isSavingPosition = false;
     void CreateFile(string _fileName, string _extension, string _data)
    {
        //1) Acceder al path del archivo 
        string path = Application.dataPath + "/resources/" + _fileName + _extension;
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
        string fileName = "Position2";
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


    Vector3 ParseStringToVector3(string input)
    {
        Vector3 result = Vector3.zero;
        string[] components = input.Split(',');

        if (components.Length == 3)
        {
            if (float.TryParse(components[0], out float x) &&
                float.TryParse(components[1],out float y)&&
                float.TryParse(components[2],out float z))
            {
                result = new Vector3(x, y, z);
            }
            else
            {
                Debug.LogError("No se pudieron convertir todos los componentes en números");
            }
            
        }
        else
        {
            Debug.LogWarning("El formato del string no es válido");
        }
        return result;
    }

    public void SaveToJSON(string _fileName, object _data)
    {
        string JSONData = JsonUtility.ToJson(_data);
        if (JSONData.Length != 0) 
        {
          Debug.Log("JSON STRING: " +  JSONData);
            CreateFile(_fileName, ".json", JSONData);
        
        }
          else
        {
            Debug.LogWarning("File System: string JSONData is empty, please check saved object" +  _fileName);
        }
    }
     void Start()
    {
        PlayerData p = new PlayerData("Camila", "Sword", 123456);
        SaveToJSON(p.Name, p);
        //CreateFile();
        SaveObjectPosition(obj.transform);
        string data = ReadFile("example", ".txt");
        Debug.Log("Informacion del archivo: \n" + data);
        // 1) Guarda la posicion en un nuevo archivo
        

        // 2) Lee la info de ese archivo 
        
       // 3) Asigna esos datos en un nuevo objeto
        
        obj2.transform.position = ParseStringToVector3(data);



        
    }

     void Update()
    {
        if (isSavingPosition)
        {
            SaveObjectPosition(obj.transform);
        }
        
    }
}
