using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System;
using UnityEngine.UIElements;
using System.Runtime.Serialization.Formatters.Binary;

public class FileSystem : MonoBehaviour
{
    public static FileSystem instance;
    public GameObject obj;
    public GameObject obj2;
    public bool isSavingPosition = false;

    public PlayerData p;

    private void Awake()
    {
        if (instance! == null)
        {
            return;
        }
        else
        {
            instance = this;
        }
    }
    void CreateFile(string _fileName, string _extension, string _data)
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
        string data = "Login Date: " + System.DateTime.Now + "\n";

        File.AppendAllText(path, _data);
    }

    void SaveObjectPosition(Transform _objTransform) 
    {
        string fileName = "Camila";
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
                float.TryParse(components[0],out float y)&&
                float.TryParse(components[0],out float z))
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
            Debug.LogWarning("El formato del string no es valido");
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
            Debug.LogWarning("File System: string JSONData is empty, please check saved object");
        }
        
    }

    public T LoadFromJSON<T>(string _fileName) where T : new()
    {
        T data = new T();
        string JSONData = ReadFile(_fileName, ".json");
        if (JSONData.Length != 0)
        {
            Debug.Log("DATA FROM FILE:" + JSONData);
            JsonUtility.FromJsonOverwrite(JSONData, data);
        }
        else
        {
            Debug.LogWarning("File System: string JSONData is empty, please check saved object");
        }
        return data;
    }

    public void SaveToBinary(string _fileName, object _data)
    {
        // creamos un nuevo formateador de binario
       
        BinaryFormatter bf = new BinaryFormatter();
        // obtener el patch para guardar y asignar el nombre del archivo 
        string path= Application.dataPath + "/Resources/" + _fileName + ".file";
        // Crear un nuevo archivo 
        FileStream stream = new FileStream(path, FileMode.Create);
        // serializamos la informacion y guardamos el archivo
        bf.Serialize(stream, _data);
        // Cerramos el archivo 
        stream.Close();

    }
     //void Start()
   // {
       // SaveToBinary("CamiSSJ", p);
        //p = LoadFromJSON<PlayerData>("Camila");
        //SaveToJSON(p.Name, p);
        //CreateFile();
       // SaveObjectPosition(obj.transform);
       /// string data = ReadFile("example", "_txt");
       /// Debug.Log("Informacion del archivo: \n" + data);
        // 1) Guarda la posicion en un nuevo archivo
        

        // 2) Lee la info de ese archivo 
        
       // 3) Asigna esos datos en un nuevo objeto
        
        //obj2.transform.position = ParseStringToVector3(data);
     //  }

     void Update()
    {
        if (isSavingPosition)
        {
            SaveObjectPosition(obj.transform);
        }
        
    }
}